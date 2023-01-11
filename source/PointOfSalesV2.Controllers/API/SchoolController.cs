

namespace PointOfSalesV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.AppSections.School)]
    public class SchoolController : BaseController<School>
    {
        public SchoolController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) :
            base(appSettings, repositoryFactory,cache,null, Common.Enums.AppSections.School)
        {
        }
    }
}