

namespace PointOfSalesV2.Entities
{
    public class PaymentType : CommonData
    {

        public short Code { get; set; }

        [Translate]
        public string Name { get; set; }

        public virtual IEnumerable<Payment> InvoicesPayments { get; set; }

        public virtual IEnumerable<ExpensesPayment> ExpensesPayments { get; set; }
        public virtual IEnumerable<Expense> Expenses { get; set; }




    }
}
