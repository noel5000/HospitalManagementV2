

namespace PointOfSalesV2.FrontEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.AppSections.InsuranceCoverage)]
    public class InsuranceServiceCoverageController : BaseController<InsuranceServiceCoverage>
    {
        readonly IInsuranceRepository _customRepo;
        public InsuranceServiceCoverageController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory,cache, null, AppSections.InsurancePlan)
        {
            _customRepo = repositoryFactory.GetCustomDataRepositories<IInsuranceRepository>();
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
                var data = await _baseRepo.GetAllAsync<InsuranceServiceCoverage>(x => x.AsNoTracking()
                .Include(t => t.Insurance)
                .Include(t=>t.Product)
                .Include(t=>t.Currency)
                .Include(t=>t.InsurancePlan)
                 , y => y.Active == true);
                return Ok(data);
               
            }

            catch (Exception ex)
            {
               await SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });
            }
        }


        [HttpGet("GetInsuranceCoverage/{productId:long}/{insuranceId}/{insurancePlanId}")]
        [ActionAuthorize(Operations.READALL)]
        [EnableCors("AllowAllOrigins")]
        public async Task<IActionResult> GetInsuranceCoverage(long productId, string insuranceId=null, string insurancePlanId=null)
        {
            try
            {
                long insurance = 0;
                long plan = 0;
                long.TryParse(insuranceId, out insurance);
                long.TryParse(insurancePlanId, out plan);
                var data = await this._customRepo.GetInsuranceCoverage(productId, insurance, plan);
                return Ok(new {id=0, status=0, data =new InsuranceServiceCoverage[] {data } });

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
                var data = await _baseRepo.GetAllAsync<InsuranceServiceCoverage>(x =>x.AsNoTracking()
                .Include(t => t.Insurance)
                .Include(t => t.Product)
                .Include(t => t.Currency)
                .Include(t => t.InsurancePlan)
                 , y => y.Active == true);
                string requestLanguage = "EN";
                var languageIdHeader = this.Request.Headers["languageid"];
                requestLanguage = languageIdHeader.FirstOrDefault() ?? "ES";
                var excelData = ExportUtility.GetExcelData<InsuranceServiceCoverage>(data, requestLanguage, this.languageKeys.ToList());
                var excelStream = ExcelImport.CreateXlsStream(
                    excelData.Item1,
                   excelData.Item2
                   );
                if (data != null && excelStream != null && excelStream.Length > 0)
                {

                    return File(excelStream.ToArray(), "application/octet-stream", $"{new InsuranceServiceCoverage().GetType().Name}-{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}.xls");
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