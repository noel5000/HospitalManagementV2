

namespace PointOfSalesV2.Repository
{
    public interface IWarehouseRepository: IBase<Warehouse>
    {
        Task<IEnumerable<Inventory>> GetProductInventory(long productId);
    }
}
