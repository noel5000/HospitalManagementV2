

namespace PointOfSalesV2.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.AppSections.CustomersReturns)]
    public class CustomerReturnDetailController : BaseController<CustomerReturnDetail>
    {
        public CustomerReturnDetailController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory,cache,null, Common.Enums.AppSections.CustomersReturns)
        {
        }
    }
}