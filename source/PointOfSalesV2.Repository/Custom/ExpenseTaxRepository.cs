

namespace PointOfSalesV2.Repository
{
    public class ExpenseTaxRepository : Repository<ExpenseTax>, IExpenseTaxRepository
    {
        public ExpenseTaxRepository(MainDataContext context) : base(context)
        {
        }

        public async Task< IEnumerable<ExpenseTax>> GetExpenseTaxes(string reference)
        {
            return await _Context.ExpenseTaxes.AsNoTracking().Where(x => x.Active == true && x.Reference.ToLower() == reference.ToLower()).ToListAsync();
        }

        public async Task<IEnumerable<ExpenseTax>> GetExpenseTaxes(long id)
        {
            return await _Context.ExpenseTaxes.AsNoTracking().Where(x => x.Active == true && x.ExpenseId==id).ToListAsync();
        }
    }
}
