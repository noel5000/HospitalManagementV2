

namespace PointOfSalesV2.Repository
{
    public interface ICustomerBalanceRepository: IBase<CustomerBalance>
    {
        Task<CustomerBalance> CustomerBalanceByCurrency(long customerId, long currencyId);

        Task<CustomerStateReport> CustomerState(long customerId);
    }
}
