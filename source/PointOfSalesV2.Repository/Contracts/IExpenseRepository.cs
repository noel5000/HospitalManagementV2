

namespace PointOfSalesV2.Repository
{
    public interface IExpenseRepository : IBase<Expense>
    {
        Task<IEnumerable<Expense>> GetDebsToPay(DateTime? startDate, DateTime? endDate, Nullable<long> supplierId, Nullable<long> currencyId, Nullable<long> branchOfficeId);
    }
}
