

namespace PointOfSalesV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.AppSections.Expenses)]
    public class ExpenseTaxController : BaseController<ExpenseTax>
    {
        public ExpenseTaxController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory,cache,null, AppSections.Expenses)
        {
        }

        [EnableCors("AllowAllOrigins")]
        [HttpGet]
        [ActionAuthorize(new Operations[] { Operations.READALL, Operations.READ })]
        [EnableQuery]
        [Microsoft.AspNetCore.OData.Routing.Attributes.ODataAttributeRouting]
        public override async Task<IActionResult> Get()
        {
            try
            {
                var data = await _baseRepo.GetAllAsync<ExpenseTax>(x => x.Include(x=>x.Tax)
                .Include(x=>x.Expense)                
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