

namespace PointOfSalesV2.Repository
{
    public interface IExpenseTaxRepository: IBase<ExpenseTax>
    {
        Task<IEnumerable<ExpenseTax>> GetExpenseTaxes(string reference);
        Task<IEnumerable<ExpenseTax>> GetExpenseTaxes(long id);
    }
}
