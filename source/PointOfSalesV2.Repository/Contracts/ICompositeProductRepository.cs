using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text; using System.Threading.Tasks;

namespace PointOfSalesV2.Repository
{
    public interface ICompositeProductRepository: IBase<CompositeProduct>
    {
        Task<IEnumerable<CompositeProduct>> GetDerivedProducts(long productId);
        Task<IEnumerable<CompositeProduct>> GetProductBases(long productId);
    }
}
