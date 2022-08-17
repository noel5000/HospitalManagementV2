
namespace PointOfSalesV2.Api.Controllers
{
    [Route("api/[controller]")]
    [ControllerAuthorize(Common.Enums.AppSections.Roles)]
    [ApiController]
    public class RoleController : BaseController<Role>
    {
        public RoleController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory,cache, null, Common.Enums.AppSections.Roles)
        {
        }
    }
}