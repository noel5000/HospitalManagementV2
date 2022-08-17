

namespace PointOfSalesV2.Repository
{
    public interface IInsuranceRepository : IBase<Insurance>
    {
        Task<InsuranceServiceCoverage> GetInsuranceCoverage(long productId, long? insuranceId, long? insurancePlanId);
    }
}
