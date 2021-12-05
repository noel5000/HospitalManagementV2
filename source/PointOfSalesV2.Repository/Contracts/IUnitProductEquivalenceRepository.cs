

namespace PointOfSalesV2.Repository
{
    public interface IUnitProductEquivalenceRepository : IBase<UnitProductEquivalence>
    {
        Task<IEnumerable<UnitProductEquivalence>> GetProductUnits(long productId);
    }
}
