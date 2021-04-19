using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PointOfSalesV2.Common;
using PointOfSalesV2.Entities;
using PointOfSalesV2.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PointOfSalesV2.Common.Enums;

namespace PointOfSalesV2.Repository
{
    public class InsuranceRepository : Repository<Insurance>, IInsuranceRepository
    {
        protected readonly IOptions<AppSettings> _appSettings;
        private readonly ISequenceManagerRepository sequence;
        public InsuranceRepository(MainDataContext context, IOptions<AppSettings> appSettings, ISequenceManagerRepository newSequence) : base(context)
        {
            this._appSettings = appSettings;
            this.sequence = newSequence;
        }




        public override Result<Insurance> Add(Insurance entity)
        {
            if (_Context.Insurances.AsNoTracking().Count(x => x.Active == true && x.Name.ToUpper() == entity.Name.ToUpper()) > 0)
            {
                return new Result<Insurance>(-1, -1, "AlreadyExist_error");
            }
            entity.Code = sequence.CreateSequence(SequenceTypes.Insurances);
            return base.Add(entity);
        }

        public async Task<InsuranceServiceCoverage> GetInsuranceCoverage(long productId, long? insuranceId, long? insurancePlanId)
        {
            insurancePlanId = insurancePlanId <= 0 ? null : insurancePlanId;
            insuranceId = insuranceId <= 0 ? null : insuranceId;
            var result = new List<InsuranceServiceCoverage>();
            InsuranceServiceCoverage selected = null;
            result = await _Context.InsuranceServiceCoverages.AsNoTracking().Where(x => x.Active == true && x.ProductId == productId).ToListAsync();
            if (!insuranceId.HasValue && !insurancePlanId.HasValue)
            {
                selected = result.FirstOrDefault(x => x.InsuranceId == null) ?? new InsuranceServiceCoverage();
                return selected;
            }

            if (result.Exists(x => x.InsuranceId == insuranceId))
            {
                result = result.Where(x => x.InsuranceId == insuranceId).ToList();

                if (result.Exists(x => x.InsurancePlanId == insurancePlanId))
                    return result.FirstOrDefault(x => x.InsurancePlanId == insurancePlanId) ?? new InsuranceServiceCoverage();
                else
                    return result.FirstOrDefault(x => x.InsurancePlanId == null) ?? new InsuranceServiceCoverage();


            }
            else
                return result.FirstOrDefault(x => x.InsuranceId == null) ?? new InsuranceServiceCoverage();
        }

        public override Result<Insurance> Update(Insurance entity, bool fromDb = true)
        {
            if (_Context.Insurances.AsNoTracking().Count(x => x.Active == true && x.Id != entity.Id
            && x.Name.ToUpper() == entity.Name.ToUpper()) > 0)
            {
                return new Result<Insurance>(-1, -1, "AlreadyExist_error");
            }
            return base.Update(entity);
        }
    }
}
