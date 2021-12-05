

namespace PointOfSalesV2.Repository
{
    public class UnitProductEquivalenceRepository : Repository<UnitProductEquivalence>, IUnitProductEquivalenceRepository
    {
        public UnitProductEquivalenceRepository(MainDataContext context) : base(context)
        {
        }

        public async Task<IEnumerable<UnitProductEquivalence>> GetProductUnits(long productId)
        {
            return await _Context.UnitProductsEquivalences.AsNoTracking().Where(x=>x.Active==true && x.ProductId==productId).ToListAsync();
        }
    }
}
