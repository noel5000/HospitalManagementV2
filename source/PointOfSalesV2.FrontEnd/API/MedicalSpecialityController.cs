

namespace PointOfSalesV2.FrontEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.AppSections.MedicalSpecialities)]
    public class MedicalSpecialityController : BaseController<MedicalSpeciality>
    {
        public MedicalSpecialityController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory,cache,null, Common.Enums.AppSections.Users)
        {
        }
    }
}