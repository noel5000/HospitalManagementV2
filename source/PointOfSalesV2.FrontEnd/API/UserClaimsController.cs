
namespace PointOfSalesV2.FrontEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserClaimsController : BaseController<UserClaims>
    {
        public UserClaimsController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory,cache)
        {
        }
    }
}