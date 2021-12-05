

namespace PointOfSalesV2.Repository
{
    public interface IProductTaxRepository : IBase<ProductTax>
    {
        Task<IEnumerable<ProductTax>> GetProductTaxes(long productId);
    }
}
