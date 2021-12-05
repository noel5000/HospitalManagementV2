
namespace PointOfSalesV2.Repository
{
    public class WarehouseTransferRepository : Repository<WarehouseTransfer>, IWarehouseTransferRepository
    {
        readonly ISequenceManagerRepository sequenceRepo;
        readonly IWarehouseMovementRepository warehouseMovements;
        public WarehouseTransferRepository(MainDataContext context, IDataRepositoryFactory repositoryFactory) : base(context)
        {
            this.sequenceRepo = repositoryFactory.GetCustomDataRepositories<ISequenceManagerRepository>();
            this.warehouseMovements = repositoryFactory.GetCustomDataRepositories<IWarehouseMovementRepository>();
        }

        public async Task<Result<object>> AddTransfersList(List<WarehouseTransfer> entries, string reference, string details)
        {
            var result = new Result<object>(-1, -1, "error_msg");

            using (var tran =await _Context.Database.BeginTransactionAsync())
            {
                try
                {
                    string sequence = await sequenceRepo.CreateSequence(SequenceTypes.WarehouseTransfers);
                    List<Inventory> inventories = new List<Inventory>();
                    entries.ForEach(e =>
                    {
                        e.Details = details;
                        e.Date = DateTime.Now;
                        e.Reference = reference;
                        e.Sequence = sequence;

                        int destinyIndex = inventories.FindIndex(x => x.ProductId == e.ProductId && x.WarehouseId == e.DestinyId);
                        int originIndex = inventories.FindIndex(x => x.ProductId == e.ProductId && x.WarehouseId == e.OriginId);
                        e.Product = e.Product != null ? e.Product : new Product() { Id = e.ProductId };
                        e.Product.ProductUnits = _Context.UnitProductsEquivalences.Include(x => x.Unit).AsNoTracking().Where(x => x.Active == true && x.ProductId == e.ProductId);
                        var convertionResult = ProductsHelper.ConvertToProductPrincipalUnit(
            e.Quantity,
            e.UnitId,
              e.Product.ProductUnits.ToList()
            );
                        if (destinyIndex < 0)
                        {
                            inventories.Add(new Inventory()
                            {
                                Quantity = convertionResult.Status >= 0 ? (decimal)convertionResult.Data.FirstOrDefault() : 0,
                                BranchOfficeId = e.DestinyBranchOfficeId,
                                ProductId = e.ProductId,
                                UnitId = e.Product.ProductUnits.FirstOrDefault(x => x.IsPrimary == true).UnitId,
                                WarehouseId = e.DestinyId
                            });
                        }
                        else
                        {
                            inventories[destinyIndex].Quantity += convertionResult.Status >= 0 ? (decimal)convertionResult.Data.FirstOrDefault() : 0;
                        }

                        if (originIndex < 0)
                        {
                            inventories.Add(new Inventory()
                            {
                                Quantity = convertionResult.Status >= 0 ? -1 * (decimal)convertionResult.Data.FirstOrDefault() : 0,
                                BranchOfficeId = e.OriginBranchOfficeId,
                                ProductId = e.ProductId,
                                UnitId = e.Product.ProductUnits.FirstOrDefault(x => x.IsPrimary == true).UnitId,
                                WarehouseId = e.OriginId
                            });
                        }
                        else
                        {
                            inventories[originIndex].Quantity += convertionResult.Status >= 0 ? -1 * (decimal)convertionResult.Data.FirstOrDefault() : 0;
                        }
                        e.OriginBranchOffice = null;
                        e.Product = null;
                        e.Unit = null;
                        e.DestinyBranchOffice = null;
                        e.Origin = null;
                        e.Destiny = null;
                    });

                    _Context.WarehousesTransfers.AddRange(entries);
                 await   _Context.SaveChangesAsync();

                    inventories.ForEach(inventory =>
                    {
                        if (inventory.Quantity != 0)
                        {
                            var currentInventory = _Context.Inventory.AsNoTracking().FirstOrDefault(x => x.ProductId == inventory.ProductId && x.WarehouseId == inventory.WarehouseId && x.UnitId == inventory.UnitId && x.Active == true);
                            if (currentInventory != null)
                            {
                                currentInventory.Quantity += inventory.Quantity;
                                _Context.Inventory.Update(currentInventory);
                            }
                            else
                                _Context.Inventory.Add(inventory);
                            _Context.SaveChanges();
                            var movement = new WarehouseMovement()
                            {
                                CurrentBalance = currentInventory != null ? currentInventory.Quantity : inventory.Quantity,
                                BranchOfficeId = inventory.BranchOfficeId,
                                MovementType = inventory.Quantity > 0 ? Enums.MovementTypes.IN.ToString() : Enums.MovementTypes.OUT.ToString(),
                                ProductId = inventory.ProductId,
                                Quantity = inventory.Quantity,
                                Reference = sequence,
                                UnitId = inventory.UnitId,
                                WarehouseId = inventory.WarehouseId
                            };
                            warehouseMovements.Add(movement);

                        }

                    });
                   await tran.CommitAsync();
                    return new Result<object>(0, 0, "ok_msg");
                }
                catch (Exception ex)
                {
                  await  tran.RollbackAsync();
                    result = new Result<object>(-1, -1, "error_msg", null, new Exception(ex.Message));
                }
            }

            return result;
        }

        public async Task<Result<object>> RemoveTransfers(string sequence)
        {
            Result<object> result = new Result<object>(-1, -1, "error_msg");
            using (var tran = await _Context.Database.BeginTransactionAsync())
            {
                try
                {
                    var entries = await _Context.WarehousesTransfers.AsNoTracking().Where(x => x.Active == true && x.Sequence == sequence).ToListAsync();
                    entries.ForEach(e =>
                    {
                        e.Active = false;
                        var productUnits = _Context.UnitProductsEquivalences.AsNoTracking().Where(x => x.Active == true && x.ProductId == e.ProductId).ToList();
                        var convertionResult = ProductsHelper.ConvertToProductPrincipalUnit(
e.Quantity,
e.UnitId,
productUnits
);
                        var DestinyInventory = _Context.Inventory.AsNoTracking().FirstOrDefault(x => x.Active == true && x.ProductId == e.ProductId && x.WarehouseId == e.DestinyId);
                        var originInventory = _Context.Inventory.AsNoTracking().FirstOrDefault(x => x.Active == true && x.ProductId == e.ProductId && x.WarehouseId == e.OriginId);

                        DestinyInventory.Quantity -= (decimal)convertionResult.Data.FirstOrDefault();
                        originInventory.Quantity += (decimal)convertionResult.Data.FirstOrDefault();
                        var movements = new List<WarehouseMovement>(){ new WarehouseMovement()
                        {
                            CurrentBalance =  originInventory.Quantity,
                            BranchOfficeId = originInventory.BranchOfficeId,
                            MovementType = Enums.MovementTypes.IN.ToString(),
                            ProductId = originInventory.ProductId,
                            Quantity = (decimal)convertionResult.Data.FirstOrDefault(),
                            Reference = sequence,
                            UnitId = originInventory.UnitId,
                            WarehouseId = originInventory.WarehouseId
                        },
                        new WarehouseMovement()
                        {
                            CurrentBalance = DestinyInventory.Quantity,
                            BranchOfficeId = DestinyInventory.BranchOfficeId,
                            MovementType = Enums.MovementTypes.OUT.ToString(),
                            ProductId = DestinyInventory.ProductId,
                            Quantity =-1* (decimal)convertionResult.Data.FirstOrDefault(),
                            Reference = sequence,
                            UnitId = DestinyInventory.UnitId,
                            WarehouseId = DestinyInventory.WarehouseId
                        }
                        };
                        _Context.Inventory.UpdateRange(new List<Inventory>()
                        {
                        DestinyInventory,
                        originInventory
                        });
                        _Context.SaveChanges();
                        warehouseMovements.AddRange(movements);

                    });
                    _Context.WarehousesTransfers.UpdateRange(entries);
                await    _Context.SaveChangesAsync();
                 await   tran.CommitAsync();
                    result = new Result<object>(0, 0, "ok_msg");
                }
                catch (Exception ex)
                {
                await    tran.RollbackAsync();
                    result = new Result<object>(-1, -1, "error_msg", null, new Exception(ex.Message));
                }
            }
            return result;
        }

        public override async Task<Result<WarehouseTransfer>> AddAsync(WarehouseTransfer entity)
        {
            throw new NotImplementedException();
        }

        public override async Task<Result<WarehouseTransfer>> UpdateAsync(WarehouseTransfer entity, bool fromDb = true)
        {
            throw new NotImplementedException();
        }
    }
}
