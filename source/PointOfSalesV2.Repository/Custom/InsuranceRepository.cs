﻿
using Microsoft.Extensions.Options;
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




        public override async Task<Result<Insurance>> AddAsync(Insurance entity)
        {
            if ( await _Context.Insurances.AsNoTracking().CountAsync(x => x.Active == true && x.Name.ToUpper() == entity.Name.ToUpper()) > 0)
            {
                return new Result<Insurance>(-1, -1, "AlreadyExist_error");
            }
            entity.Code = await sequence.CreateSequence(SequenceTypes.Insurances);
            return await base.AddAsync(entity);
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

        public override async Task< Result<Insurance>> UpdateAsync(Insurance entity, bool fromDb = true)
        {
            if ( await _Context.Insurances.AsNoTracking().CountAsync(x => x.Active == true && x.Id != entity.Id
            && x.Name.ToUpper() == entity.Name.ToUpper()) > 0)
            {
                return new Result<Insurance>(-1, -1, "AlreadyExist_error");
            }
            return await base.UpdateAsync(entity);
        }
    }
}
