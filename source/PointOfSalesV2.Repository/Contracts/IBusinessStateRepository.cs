

namespace PointOfSalesV2.Repository
{
    public interface IBusinessStateRepository 
    {
        Task<List<object>> GetFinancialState(DateTime? startDate, DateTime? endDate);

       Task< List<TaxesReport>> GetTaxesReport(DateTime? startDate, DateTime? endDate);
    }
}
