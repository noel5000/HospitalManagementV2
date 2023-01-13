
namespace PointOfSalesV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserClaimsController : BaseController<UserClaims>
    {
        protected readonly ITenantService _tenantService;
        public UserClaimsController(IOptions<AppSettings> appSettings, ITenantService tenantService, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory,cache)
        {
            _tenantService = tenantService;
        }


        [HttpGet]
        [ActionAuthorize(Operations.READALL)]
        [EnableQuery]
        [Microsoft.AspNetCore.OData.Routing.Attributes.ODataAttributeRouting]
        [EnableCors("AllowAllOrigins")]
        public override async Task<IActionResult> Get()
        {
            try
            {
                var data = await _baseRepo.GetAllAsync<UserClaims>(x => x, y => y.Active && y.TenantId == _tenantService.Tenant);
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