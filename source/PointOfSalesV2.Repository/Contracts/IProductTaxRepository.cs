using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text; using System.Threading.Tasks;

namespace PointOfSalesV2.Repository
{
    public interface IProductTaxRepository : IBase<ProductTax>
    {
        Task<IEnumerable<ProductTax>> GetProductTaxes(long productId);
    }
}
