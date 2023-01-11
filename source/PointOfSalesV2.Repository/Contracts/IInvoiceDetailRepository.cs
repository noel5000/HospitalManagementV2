

namespace PointOfSalesV2.Repository
{
    public interface IInvoiceDetailRepository: IBase<InvoiceDetail>
    {
        Task<IEnumerable<InvoiceDetail>> GetByProductId(long productId);
       Task<IEnumerable<InvoiceDetail>> GetByInvoiceId(long invoiceId);
       Task<IEnumerable<InvoiceDetail>> GetChildren(long parentId);
       Task<IEnumerable<InvoiceDetail>> GetInvoiceParentsDetails(long invoiceId);
    }
}
