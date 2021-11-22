using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text; using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PointOfSalesV2.Repository
{
    public class InvoiceDetailRepository : Repository<InvoiceDetail>, IInvoiceDetailRepository
    {
        public InvoiceDetailRepository(MainDataContext context) : base(context)
        {
        }

        public async Task<IEnumerable<InvoiceDetail>> GetByInvoiceId(long invoiceId)
        {
            return await _Context.InvoiceDetails.AsNoTracking().Include(x=>x.Product).Where(x => x.Active == true && x.InvoiceId == invoiceId).ToListAsync();
        }

        public async Task<IEnumerable<InvoiceDetail>> GetByProductId(long productId)
        {
            return await _Context.InvoiceDetails.AsNoTracking().Where(x => x.Active == true && x.ProductId == productId).ToListAsync();
        }

        public async Task<IEnumerable<InvoiceDetail> >GetChildren(long parentId)
        {
            return await _Context.InvoiceDetails.AsNoTracking().Where(x => x.Active == true && x.ParentId==parentId).ToListAsync();
        }

        public async Task<IEnumerable<InvoiceDetail>> GetInvoiceParentsDetails(long invoiceId)
        {
            return await _Context.InvoiceDetails.AsNoTracking().Where(x => x.Active == true && x.InvoiceId == invoiceId && x.ParentId==null).ToListAsync();
        }
    }
}
