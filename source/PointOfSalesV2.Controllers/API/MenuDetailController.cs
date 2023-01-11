

namespace PointOfSalesV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.AppSections.SchoolMenu)]
    public class MenuDetailController : BaseController<MenuDetail>
    {
      
        public MenuDetailController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory,cache,null, AppSections.SchoolMenu)
        {
  
        }

        [HttpGet]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(new Operations[] { Operations.READALL, Operations.READ })]
        [EnableQuery]
        [Microsoft.AspNetCore.OData.Routing.Attributes.ODataAttributeRouting]
        public override async Task<IActionResult> Get()
        {
            try
            {
                var data = await _baseRepo.GetAllAsync<MenuDetail>(x =>x.Include(t=>t.Product)
                .Include(t=>t.Unit)
                .Include(t=>t.Menu)
                , y => y.Active == true);
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