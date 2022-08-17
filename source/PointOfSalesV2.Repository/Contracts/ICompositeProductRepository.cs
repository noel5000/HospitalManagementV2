

namespace PointOfSalesV2.Repository
{
    public interface ICompositeProductRepository: IBase<CompositeProduct>
    {
        Task<IEnumerable<CompositeProduct>> GetDerivedProducts(long productId);
        Task<IEnumerable<CompositeProduct>> GetProductBases(long productId);
    }
}
