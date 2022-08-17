

namespace PointOfSalesV2.Repository
{
    public class CustomerBalanceRepository : Repository<CustomerBalance>, ICustomerBalanceRepository
    {
        public CustomerBalanceRepository(MainDataContext context) : base(context)
        {
        }

        public async Task<CustomerBalance> CustomerBalanceByCurrency(long customerId, long currencyId)
        {
            return await _Context.CustomersBalance.AsNoTracking().Include(x=>x.Customer).Include(x=>x.Currency).FirstOrDefaultAsync(x => x.Active == true && x.CurrencyId == currencyId && x.CustomerId == customerId);
        }

        public async Task<CustomerStateReport> CustomerState(long customerId)
        {
            CustomerStateReport report = new CustomerStateReport();
            report.Customer = await _Context.Customers.FindAsync(customerId);
            var customerInvoices = await _Context.Invoices.Include(x => x.Currency)
                .Include(x => x.Payments).ThenInclude(d => d.Currency)
                .Include(x => x.Payments).ThenInclude(d => d.Seller)
                .Include(x => x.Seller)
                .AsNoTracking().Where(x => x.Active == true && (x.State == (char)BillingStates.Billed || x.State == (char)BillingStates.Paid || x.State == (char)BillingStates.FullPaid) && x.CustomerId==customerId).ToListAsync();
            customerInvoices.ForEach(x =>
            {
                report.Data.Add(new CustomerStateModel()
                {
                    DocumentNumber = string.IsNullOrEmpty( x.InvoiceNumber)?x.DocumentNumber:x.InvoiceNumber,
                    Date = x.BillingDate.HasValue?x.BillingDate.Value:x.CreatedDate,
                    CurrencyId = x.CurrencyId,
                    CurrencyName = x.Currency.Code,
                    SellerName = x.Seller?.NameAndCode ?? "N/A",
                    Reference = "N/A",
                    Credit = 0,
                    Debit = x.PatientPaymentAmount,
                    Balance = x.OwedAmount,
                    CustomerName=report.Customer?.NameAndCode??""
                });
                x.Payments = x.Payments == null ? new List<CustomerPayment>() : x.Payments.Where(x=>x.Active==true && x.State==(char)BillingStates.Paid).ToList();
                x.Payments.ForEach(p => {
                    report.Data.Add(new CustomerStateModel()
                    {
                        Reference = p.InvoiceNumber,
                        Date = p.Date,
                        CurrencyId = p.CurrencyId,
                        CurrencyName = p.Currency.Code,
                        SellerName = p.Seller?.NameAndCode ?? "N/A",
                        DocumentNumber = p.Sequence,
                        Credit = p.PaidAmount,
                        Debit = 0,
                        Balance = 0,
                        CustomerName = report.Customer.NameAndCode
                    });
                });

            });
            report.TotalBilledAmount = report.Data.Sum(x => x.Debit);
            report.TotalPaidAmount = report.Data.Sum(x => x.Credit);
            report.TotalOwedAmount = report.TotalBilledAmount - report.TotalPaidAmount;
            return report;
        }
    }
}
