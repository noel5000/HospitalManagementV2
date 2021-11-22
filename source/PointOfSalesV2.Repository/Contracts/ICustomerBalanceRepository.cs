using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text; using System.Threading.Tasks;

namespace PointOfSalesV2.Repository
{
    public interface ICustomerBalanceRepository: IBase<CustomerBalance>
    {
        Task<CustomerBalance> CustomerBalanceByCurrency(long customerId, long currencyId);

        Task<CustomerStateReport> CustomerState(long customerId);
    }
}
