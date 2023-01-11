

namespace PointOfSalesV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovementTypeController : BaseController<MovementType>
    {
        public MovementTypeController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory,cache,null, Common.Enums.AppSections.NotSpecified)
        {
        }
    }
}