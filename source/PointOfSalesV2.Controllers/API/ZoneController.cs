

namespace PointOfSalesV2.Controllers
{
    [Route("api/[controller]")]
    [ControllerAuthorize(Common.Enums.Controllers.Zone)]
    [ApiController]
    public class ZoneController : BaseController<Zone>
    {
        public ZoneController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory,cache,null,Common.Enums.Controllers.Zone)
        {
        }
    }
}
