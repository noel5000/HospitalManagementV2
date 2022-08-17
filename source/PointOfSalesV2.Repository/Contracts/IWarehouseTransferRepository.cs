
namespace PointOfSalesV2.Repository
{
    public interface IWarehouseTransferRepository: IBase<WarehouseTransfer>
    {
        Task<Result<object>> AddTransfersList(List<WarehouseTransfer> entries, string reference, string details);
       Task<Result<object>> RemoveTransfers(string sequence);
    }
}
