
namespace PointOfSalesV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.Controllers.Supplier)]
    public class SupplierBalanceController : BaseController<SupplierBalance>
    {
        public SupplierBalanceController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : 
            base(appSettings, repositoryFactory,cache, null, Common.Enums.Controllers.Supplier)
        {
        }
    }
}