using PointOfSalesV2.Entities;
using PointOfSalesV2.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text; using System.Threading.Tasks;

namespace PointOfSalesV2.Repository
{
    public interface IInsuranceRepository : IBase<Insurance>
    {
        Task<InsuranceServiceCoverage> GetInsuranceCoverage(long productId, long? insuranceId, long? insurancePlanId);
    }
}
