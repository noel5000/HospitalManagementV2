
namespace PointOfSalesV2.Repository
{
    public interface ICashRegisterOpeningRepository : IBase<CashRegisterOpening>
    {
        Task<Result<CashRegisterOpening>> Closure(CashRegisterOpening cashRegisterOpening);
    }
}
