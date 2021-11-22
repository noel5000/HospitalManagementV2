using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text; using System.Threading.Tasks;

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
