using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text; using System.Threading.Tasks;

namespace PointOfSalesV2.Repository
{
    public interface IInvoiceRepository: IBase<Invoice>
    {
        Task<IEnumerable<Invoice>> GetAccountsReceivable(DateTime? startDate, DateTime? endDate, Nullable<long> customerId, Nullable<long> currencyId, long? sellerId,long?branchOfficeId);
      Task<IEnumerable<Invoice>> GetSales(DateTime? startDate, DateTime? endDate, Nullable<long> customerId, Nullable<long> currencyId, Nullable<long> sellerId, long? branchOfficeId);
      Task<Invoice> GetByInvoiceNumber(string invoiceNumber);

       Task<Result<Invoice>> BillQuote(long quoteId);
      Task<PagedList<Invoice>> GetPagedQuotes(int page, int size);
       Task<IEnumerable<object> >GetAccountStatus(DateTime? startDate, DateTime? endDate, long? customerId, long? currencyId);
      Task<IEnumerable<Invoice>> GetInvoicesToPay(long branchOfficeId = 0, long currencyId = 0, long customerId = 0);

        Task<List<CompanyStateModel> >GetCompanyStatus(DateTime? initialDate, DateTime? endDate);

      Task<List<InsurancCoverageDetail> >GetInsuranceCoverages(DateTime? startDate, DateTime? endDate, long? insuranceId, long? insurancePlanId, long? currencyId, long? branchOfficeId);

    }
}
