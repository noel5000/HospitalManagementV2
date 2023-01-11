

namespace PointOfSalesV2.FrontEnd.Controllers
{
    [Route("api/[controller]")]
    [ControllerAuthorize(Common.Enums.AppSections.Zones)]
    [ApiController]
    public class ZoneController : BaseController<Zone>
    {
        public ZoneController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory,cache,null,Common.Enums.AppSections.Zones)
        {
        }
    }
}
