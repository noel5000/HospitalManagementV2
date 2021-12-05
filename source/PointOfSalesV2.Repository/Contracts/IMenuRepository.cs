

namespace PointOfSalesV2.Repository
{
    public interface IMenuRepository : IBase<Menu>
    {
        Task<Result<object>> DeleteMenuEntry(byte weekNo, DayOfWeek dayOfWeek);
       Task<List<InvoiceLeadProjection>> MonthProjection(DateTime currentDate, long branchOfficeId=0, long warehouseId=0);
    }
}
