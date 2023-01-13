

namespace PointOfSalesV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.Controllers.CustomerReturnDetail)]
    public class CustomerReturnDetailController : BaseController<CustomerReturnDetail>
    {
        public CustomerReturnDetailController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory,cache,null, Common.Enums.Controllers.CustomerReturn)
        {
        }
    }
}