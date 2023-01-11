

namespace PointOfSalesV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.AppSections.CashRegisterOpenings)]
    public class OpeningAmountController : BaseController<OpeningAmount>
    {
        public OpeningAmountController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory,cache, null, Common.Enums.AppSections.CashRegisterOpenings)
        {
        }
    }
}