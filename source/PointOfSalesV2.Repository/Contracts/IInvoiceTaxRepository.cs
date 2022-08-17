

namespace PointOfSalesV2.Repository
{
    public interface IInvoiceTaxRepository: IBase<InvoiceTax>
    {
        Task<IEnumerable<InvoiceTax>> GetInvoiceTaxes(string invoiceNumber);
       Task<IEnumerable<InvoiceTax>> GetInvoiceTaxes(long invoiceID);
    }
}
