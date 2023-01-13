

namespace PointOfSalesV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.Controllers.MedicalSpeciality)]
    public class MedicalSpecialityController : BaseController<MedicalSpeciality>
    {
        public MedicalSpecialityController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) :
            base(appSettings, repositoryFactory,cache,null, Common.Enums.Controllers.MedicalSpeciality)
        {
        }
    }
}