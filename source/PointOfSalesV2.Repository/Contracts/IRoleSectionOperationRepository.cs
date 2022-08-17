

namespace PointOfSalesV2.Repository
{
    public interface IRoleSectionOperationRepository : IBase<RoleSectionOperation>
    {
        Task<IQueryable<RoleSectionOperation>> GetWithAllChildren();
    }
}
