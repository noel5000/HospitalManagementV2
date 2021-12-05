

namespace PointOfSalesV2.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.AppSections.CustomerPayments)]
    public class PaymentDetailController : BaseController<PaymentDetail>
    {
        public PaymentDetailController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory,cache,null, Common.Enums.AppSections.CustomerPayments)
        {
        }
    }
}