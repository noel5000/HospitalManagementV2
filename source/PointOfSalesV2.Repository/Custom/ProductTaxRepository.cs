

namespace PointOfSalesV2.Repository
{
    public class ProductTaxRepository : Repository<ProductTax>, IProductTaxRepository
    {
        public ProductTaxRepository(MainDataContext context) : base(context)
        {
        }

        public async Task<IEnumerable<ProductTax>> GetProductTaxes(long productId)
        {
            return await _Context.ProductTaxes.AsNoTracking().Where(x => x.Active == true && x.ProductId == productId).ToListAsync();
        }
    }
}
