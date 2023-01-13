

namespace PointOfSalesV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.Controllers.BranchOffice)]
    public class BranchOfficeController : BaseController<BranchOffice>
    {
        public BranchOfficeController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory,cache,null, Common.Enums.Controllers.BranchOffice)
        {
        }
    }
}