using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PointOfSalesV2.Common;
using PointOfSalesV2.Entities;
using PointOfSalesV2.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        protected readonly IOptions<AppSettings> _appSettings;
        public CustomerRepository(MainDataContext context, IOptions<AppSettings> appSettings) : base(context)
        {
            this._appSettings = appSettings;
        }

        public override Result<Customer> Get(long id)
        {
            var result = new Result<Customer>(-1, -1, "error_msg");
            try
            {
                var entity = _Context.Customers.AsNoTracking().Include(x => x.Currency).Include(x => x.TRNControl).Include(x => x.Zone).Include(x => x.Insurance)
                    .Include(x => x.InsurancePlan).FirstOrDefault(x => x.Active == true && x.Id == id);
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


        public override Result<Customer> Add(Customer entity)
        {
            if (_Context.Customers.AsNoTracking().Count(x => x.Active == true && x.CardId.ToUpper() == entity.CardId.ToUpper()) > 0) 
            {
                return new Result<Customer>(-1, -1, "cardIdAlreadyExist_error");
            }
            return base.Add(entity);
        }

        public override Result<Customer> Update(Customer entity, bool fromDb = true)
        {
            if (_Context.Customers.AsNoTracking().Count(x => x.Active == true && x.Id!=entity.Id &&
            x.CardId.ToUpper() == entity.CardId.ToUpper()) > 0)
            {
                return new Result<Customer>(-1, -1, "cardIdAlreadyExist_error");
            }
            return base.Update(entity);
        }
    }
}
