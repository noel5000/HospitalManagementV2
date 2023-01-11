

namespace PointOfSalesV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.AppSections.CashRegisterOpenings)]
    public class CashRegisterOpeningDetailController : BaseController<CashRegisterOpeningDetail>
    {
        public CashRegisterOpeningDetailController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory,cache, null, AppSections.CashRegisterOpenings)
        {
        }

        [HttpGet]
        [ActionAuthorize(new Operations[] { Operations.READALL, Operations.READ })]
        [EnableQuery]
        [Microsoft.AspNetCore.OData.Routing.Attributes.ODataAttributeRouting]
        [EnableCors("AllowAllOrigins")]
        public override async Task<IActionResult> Get()
        {
            try
            {
                var data = await _baseRepo.GetAllAsync<CashRegisterOpeningDetail>(x => x.Include(x => x.CashRegisterOpening)
                .Where(y => y.Active == true));
                return Ok(data);
            }

            catch (Exception ex)
            {
               await SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });
            }
        }
    }
}