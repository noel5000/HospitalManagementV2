

namespace PointOfSalesV2.Repository
{
    public interface IInventoryRepository: IBase<Inventory>
    {
        Task<IEnumerable<Inventory>> GetWarehouseInventoryByProduct(long warehouseId,long productId);
       Task<IEnumerable<Inventory>> GetWarehouseInventory(long warehouseId);
       Task<IEnumerable<Inventory>> GetProductInventory(long productId);
       Task<IEnumerable<Inventory>> GetBranchOfficeInventory(long branchOfficeId, long? productId);
        Task<IEnumerable<object>> GetCompanyInventory(long branchOfficeId = 0, long warehouseId = 0, long productId = 0);
    }
}
