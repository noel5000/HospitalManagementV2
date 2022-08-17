

namespace PointOfSalesV2.Repository
{
    public interface IExpensesPaymentRepository : IBase<ExpensesPayment>
    {
        Task<Result<Payment>> AddPayment(CompanyPayments payment, List<Expense> expenses);
        Result<Payment> AddPaymentWithoutTransaction(CompanyPayments payment, Expense expenses, SequenceControl expenseSeqControl);
    }
}
