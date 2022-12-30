

namespace PointOfSalesV2.FrontEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.AppSections.InsurancePlan)]
    public class InsurancePlanController : BaseController<InsurancePlan>
    {
        readonly IProductRepository _customRepo;
        public InsurancePlanController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory,cache,null, AppSections.InsurancePlan)
        {
            _customRepo = repositoryFactory.GetCustomDataRepositories<IProductRepository>();
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
                var data = await _baseRepo.GetAllAsync<InsurancePlan>(x => x.AsNoTracking()
                .Include(t => t.Insurance)
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
                var data = await _baseRepo.GetAllAsync<InsurancePlan>(x => x.AsNoTracking()
                .Include(t => t.Insurance)
                 , y => y.Active == true);
                string requestLanguage = "EN";
                var languageIdHeader = this.Request.Headers["languageid"];
                requestLanguage = languageIdHeader.FirstOrDefault() ?? "ES";
                var excelData = ExportUtility.GetExcelData<InsurancePlan>(data, requestLanguage, this.languageKeys.ToList());
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