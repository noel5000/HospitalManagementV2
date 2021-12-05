

namespace PointOfSalesV2.Repository
{
    public interface IInventoryEntryRepository: IBase<InventoryEntry>
    {
        Task<Result<object>> RemoveEntries(string sequence);
        Task<Result<object>> AddInventoryList(List<InventoryEntry> entries, string reference, string details);
    }
}
