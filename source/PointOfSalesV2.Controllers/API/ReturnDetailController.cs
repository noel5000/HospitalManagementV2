

namespace PointOfSalesV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.Controllers.ReturnDetail)]
    public class ReturnDetailController : BaseController<ReturnDetail>
    {
        public ReturnDetailController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) :
            base(appSettings, repositoryFactory,cache, null, Common.Enums.Controllers.ReturnDetail)
        {
        }
    }
}