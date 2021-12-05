
namespace PointOfSalesV2.Repository
{
    public class CompositeProductRepository : Repository<CompositeProduct>, ICompositeProductRepository
    {
        public CompositeProductRepository(MainDataContext context) : base(context)
        {
        }

        public async Task<IEnumerable<CompositeProduct>> GetDerivedProducts(long productId)
        {
            return await base._Context.CompositeProducts.AsNoTracking().Where(x => x.Active == true && x.BaseProductId == productId).ToListAsync();
        }

        public async Task<IEnumerable<CompositeProduct>> GetProductBases(long productId)
        {
            return await _Context.CompositeProducts.AsNoTracking().Where(x => x.Active == true && x.ProductId == productId).ToListAsync();
        }
    }
}
