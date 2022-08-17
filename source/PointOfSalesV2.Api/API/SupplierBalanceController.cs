
namespace PointOfSalesV2.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.AppSections.Suppliers)]
    public class SupplierBalanceController : BaseController<SupplierBalance>
    {
        public SupplierBalanceController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory,cache, null, Common.Enums.AppSections.Suppliers)
        {
        }
    }
}