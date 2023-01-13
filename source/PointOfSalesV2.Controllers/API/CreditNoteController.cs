

namespace PointOfSalesV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.Controllers.CreditNote)]
    public class CreditNoteController : BaseController<CreditNote>
    {
        public CreditNoteController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : 
            base(appSettings, repositoryFactory,cache, null, Common.Enums.Controllers.CreditNote)
        {
        }
    }
}