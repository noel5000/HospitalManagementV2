

namespace PointOfSalesV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.Controllers.RoleSectionOperation)]
    public class SectionController : BaseController<Section>
    {
        public SectionController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) :
            base(appSettings, repositoryFactory,cache,null, Enums.Controllers.RoleSectionOperation)
        {
        }

       
    }
}