using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PointOfSalesV2.Common;
using PointOfSalesV2.Entities;
using PointOfSalesV2.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; using System.Threading.Tasks;

namespace PointOfSalesV2.Repository
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        protected readonly IOptions<AppSettings> _appSettings;
        public CustomerRepository(MainDataContext context, IOptions<AppSettings> appSettings) : base(context)
        {
            this._appSettings = appSettings;
        }

        public override async Task<Result<Customer>> GetAsync(long id)
        {
            var result = new Result<Customer>(-1, -1, "error_msg");
            try
            {
                var entity = await _Context.Customers.AsNoTracking().Include(x => x.Currency).Include(x => x.TRNControl).Include(x => x.Zone).Include(x => x.Insurance)
                    .Include(x => x.InsurancePlan).FirstOrDefaultAsync(x => x.Active == true && x.Id == id);
                if (entity == null)
                    result = new Result<Customer>(-1, -1, "notFound_msg");
                else
                    result = new Result<Customer>(id, 0, "ok_msg", new List<Customer>() { entity });
            }
            catch (Exception ex) 
            {
                result = new Result<Customer>(-1, -1, ex.Message, null, ex);

            }
            return result;
        }


        public override async Task<Result<Customer>> AddAsync(Customer entity)
        {
            if (!string.IsNullOrEmpty(entity.CardId) &&  await _Context.Customers.AsNoTracking().CountAsync(x => x.Active == true && x.CardId.ToUpper() == entity.CardId.ToUpper()) > 0) 
            {
                return new Result<Customer>(-1, -1, "cardIdAlreadyExist_error");
            }

            if (!string.IsNullOrEmpty(entity.Name) && await _Context.Customers.AsNoTracking().CountAsync(x => x.Active == true && x.Name.Trim().ToUpper() == entity.Name.Trim().ToUpper()) > 0)
            {
                return new Result<Customer>(-1, -1, "alreadyExist_error");
            }
            return await base.AddAsync(entity);
        }

        public override async Task<Result<Customer>> UpdateAsync(Customer entity, bool fromDb = true)
        {
            if ( await _Context.Customers.AsNoTracking().CountAsync(x => x.Active == true && x.Id!=entity.Id &&
            x.CardId.ToUpper() == entity.CardId.ToUpper()) > 0)
            {
                return new Result<Customer>(-1, -1, "cardIdAlreadyExist_error");
            }
            this.CleanObject(entity);
            

            return  await base.UpdateAsync(entity);
        }
        void CleanObject(Customer entity) {
            entity.Currency = null;
            entity.CustomerBalances = null;
            entity.Insurance = null;
            entity.InsurancePlan = null;
            entity.TRNControl = null;
            entity.Zone = null;
        }
    }
}
