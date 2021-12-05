
namespace PointOfSalesV2.Repository
{
    public class WarehouseMovementRepository : Repository<WarehouseMovement>, IWarehouseMovementRepository
    {
        public WarehouseMovementRepository(MainDataContext context) : base(context)
        {
        }

        public async Task< IEnumerable<WarehouseMovement>> GetMovementsByProduct(long? productId, long? warehouseId, DateTime? initialDate, DateTime? endDate)
        {
            return await _Context.WarehousesMovements.AsNoTracking().Where(x => x.Active == true &&
            (warehouseId.HasValue ? x.WarehouseId == warehouseId.Value : x.WarehouseId > 0) &&
             (initialDate.HasValue ? x.CreatedDate >= initialDate.Value : x.CreatedDate > DateTime.MinValue) &&
             (endDate.HasValue ? x.CreatedDate <= endDate.Value : x.CreatedDate< DateTime.Now) &&
            (productId.HasValue ? x.ProductId == productId.Value : x.ProductId > 0)).ToListAsync();
        }

        public async Task< IEnumerable<WarehouseMovement>> GetProductHistory(long? productId)
        {
            return await _Context.WarehousesMovements.AsNoTracking().Where(x => x.Active == true &&
            (productId.HasValue ? x.ProductId == productId.Value : x.ProductId > 0)).ToListAsync();
        }
    }
}
