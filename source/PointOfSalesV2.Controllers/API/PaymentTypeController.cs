

namespace PointOfSalesV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.AppSections.PaymentTypes)]
    public class PaymentTypeController : BaseController<PaymentType>
    {
        public PaymentTypeController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory,cache,null, Common.Enums.AppSections.PaymentTypes)
        {
        }
    }
}