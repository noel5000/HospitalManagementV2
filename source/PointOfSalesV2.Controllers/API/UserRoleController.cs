

namespace PointOfSalesV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.Controllers.UserRole)]
    public class UserRoleController : BaseController<UserRole>
    {
        protected readonly ITenantService _tenantService;
        public UserRoleController(IOptions<AppSettings> appSettings, ITenantService tenantService, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory,cache,null, Enums.Controllers.UserRole)
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
                var data = await _baseRepo.GetAllAsync<UserRole>(x => x.Include(r=>r.Role).Where(y => y.Active == true),y=>y.Active && y.TenantId==_tenantService.Tenant);
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