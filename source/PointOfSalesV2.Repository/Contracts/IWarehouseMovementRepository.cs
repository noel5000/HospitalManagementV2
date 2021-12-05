
namespace PointOfSalesV2.Repository
{
    public interface IWarehouseMovementRepository : IBase<WarehouseMovement>
    {
        Task<IEnumerable<WarehouseMovement>> GetMovementsByProduct(long? productId, long? warehouseId, DateTime? initialDate, DateTime? endDate);
        Task<IEnumerable<WarehouseMovement>> GetProductHistory(long? productId);
    }
}
