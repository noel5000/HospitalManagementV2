using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PointOfSalesV2.Common;
using PointOfSalesV2.Entities;
using PointOfSalesV2.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public override Result<Insurance> Update(Insurance entity, bool fromDb = true)
        {
            if (_Context.Insurances.AsNoTracking().Count(x => x.Active == true && x.Id!=entity.Id 
            && x.Name.ToUpper() == entity.Name.ToUpper()) > 0)
            {
                return new Result<Insurance>(-1, -1, "AlreadyExist_error");
            }
            return base.Update(entity);
        }
    }
}
