

namespace PointOfSalesV2.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.AppSections.Insurance)]
    public class InsuranceController : BaseController<Insurance>
    {
        
        readonly ISequenceManagerRepository sequence;
        public InsuranceController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory,cache,repositoryFactory.GetCustomDataRepositories<IInsuranceRepository>(), AppSections.Insurance)
        {
            this.sequence = this._repositoryFactory.GetCustomDataRepositories<ISequenceManagerRepository>();
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
                var data = await _baseRepo.GetAllAsync<Insurance>(x =>x.AsNoTracking()
                 , y => y.Active == true);
                return Ok(data);
               
            }

            catch (Exception ex)
            {
               await SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });
            }
        }

        [HttpPost("ExportToExcel")]
        [EnableCors("AllowAllOrigins")]
        [Microsoft.AspNetCore.OData.Routing.Attributes.ODataAttributeRouting]
        [ActionAuthorize(Operations.EXPORT)]
        public override async Task<IActionResult> ExportToExcel()
        {
            try
            {
                var data = await _baseRepo.GetAllAsync<Insurance>(x => x.AsNoTracking()
                 , y => y.Active == true);
                string requestLanguage = "EN";
                var languageIdHeader = this.Request.Headers["languageid"];
                requestLanguage = languageIdHeader.FirstOrDefault() ?? "ES";
                var excelData = ExportUtility.GetExcelData<Insurance>(data, requestLanguage, this.languageKeys.ToList());
                var excelStream = ExcelImport.CreateXlsStream(
                    excelData.Item1,
                   excelData.Item2
                   );
                if (data != null && excelStream != null && excelStream.Length > 0)
                {

                    return File(excelStream.ToArray(), "application/octet-stream", $"{new Insurance().GetType().Name}-{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}.xls");
                }
                return BadRequest(new { status = -1, message = "documentDoesntExist_msg" });


            }

            catch (Exception ex)
            {
               await SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });
            }
        }
    }
}