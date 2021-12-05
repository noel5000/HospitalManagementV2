

namespace PointOfSalesV2.Repository
{
    public class InventoryRepository : Repository<Inventory>, IInventoryRepository
    {
        public InventoryRepository(MainDataContext context) : base(context)
        {
        }
       

        public async Task<IEnumerable<Inventory>> GetBranchOfficeInventory(long branchOfficeId, long? productId)
        {

            return await _Context.Inventory.Include(x=>x.BranchOffice).Include(x=>x.Warehouse).Include(x=>x.Product).Include(x=>x.Unit).AsNoTracking().Where(
                inventory => inventory.Active == true && (productId.HasValue ? inventory.ProductId == productId.Value : inventory.Id > 0) &&
            inventory.BranchOfficeId == branchOfficeId
                ).ToListAsync();
        }

        public async Task<IEnumerable<object>> GetCompanyInventory(long branchOfficeId = 0, long warehouseId = 0, long productId = 0)
        {
            List<object> result = new List<object>();
            var data = (await this.GetAllAsync<Inventory>(x => x.Include(i => i.Product)
            .Include(i => i.Warehouse)
            .Include(i => i.BranchOffice)
            .Include(i => i.Unit)
            , y => y.Active == true
               && (branchOfficeId > 0 ? y.BranchOfficeId == branchOfficeId : y.BranchOfficeId > 0)
               && (warehouseId > 0 ? y.WarehouseId == warehouseId : y.WarehouseId > 0)
               && (productId > 0 ? y.ProductId == productId : y.ProductId > 0)))
               .ToList()
                .GroupBy(x => x.BranchOfficeId)
               .ToList();
            data.ForEach(i => {
                BranchOffice branchOffice = new BranchOffice()
                {
                    Id = i.FirstOrDefault().BranchOffice.Id,
                    Name = i.FirstOrDefault().BranchOffice.Name
                };
                List<Warehouse> warehouses = new List<Warehouse>();
                i.GroupBy(x => x.WarehouseId).ToList().ForEach(w =>
                {
                    warehouses.Add(new Warehouse()
                    {
                        Id = w.FirstOrDefault().Warehouse.Id,
                        Name = w.FirstOrDefault().Warehouse.Name,
                        Code = w.FirstOrDefault().Warehouse.Code
                    });
                });
                warehouses.ForEach(n => {
                    n.Inventory = i.Where(e => e.WarehouseId == n.Id).Select(x => new Inventory()
                    {
                        Warehouse = new Warehouse() { Name = n.Name, Id = n.Id },
                        ProductId = x.ProductId,
                        Product = new Product { Id = x.Product.Id, Name = x.Product.Name },
                        Unit = new Unit() { Id = x.Unit.Id, Name = x.Unit.Name },
                        UnitId = x.UnitId,
                        Quantity = x.Quantity,
                    }).ToList();
                });
                branchOffice.Warehouses = warehouses;
                result.Add(branchOffice);
            });
            return result;
        }

        public async Task<IEnumerable<Inventory>> GetProductInventory(long productId)
        {
            return await _Context.Inventory.Include(i=>i.Warehouse).Include(x => x.BranchOffice).Include(x => x.Product).Include(x => x.Unit).AsNoTracking().Where(x=>x.Active==true && x.ProductId==productId).ToListAsync();
        }

        public async Task<IEnumerable<Inventory>> GetWarehouseInventory(long warehouseId)
        {
            return await _Context.Inventory.Include(x => x.BranchOffice).Include(x => x.Product).Include(x => x.Unit).AsNoTracking().Where(x => x.Active == true && x.WarehouseId == warehouseId).ToListAsync();
        }

        public async Task<IEnumerable<Inventory>> GetWarehouseInventoryByProduct(long warehouseId, long productId)
        {
            return await _Context.Inventory.Include(x => x.BranchOffice).Include(x => x.Product).Include(x => x.Unit).AsNoTracking()
                .Where(x => x.Active == true && x.ProductId == productId && x.WarehouseId==warehouseId).ToListAsync();
        }
    }
}
