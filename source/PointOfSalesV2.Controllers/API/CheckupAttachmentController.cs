

namespace PointOfSalesV2.Controllers
{
    [Route("api/[controller]")]
    [ControllerAuthorize(Common.Enums.AppSections.PatientCheckup)]
    [ApiController]
    public class CheckupAttachmentController : BaseController<CheckupAttachment>
    {
        public CheckupAttachmentController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory,cache,null, AppSections.PatientCheckup)
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
                var data = await _baseRepo.GetAllAsync<CheckupAttachment>(x => x.Include(t => t.FileAttachment)
                .Include(t => t.PatientCheckup)
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