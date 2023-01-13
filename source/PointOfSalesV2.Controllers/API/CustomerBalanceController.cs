

namespace PointOfSalesV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.Controllers.Customer)]
    public class CustomerBalanceController : BaseController<CustomerBalance>
    {
        public CustomerBalanceController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory,cache,null, Common.Enums.Controllers.Customer)
        {
        }
    }
}