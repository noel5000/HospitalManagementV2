

namespace PointOfSalesV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.Controllers.TrnControl)]
    public class TRNControlController : BaseController<TRNControl>
    {
        public TRNControlController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : 
            base(appSettings, repositoryFactory,cache, null, Common.Enums.Controllers.TrnControl)
        {
        }
    }
}