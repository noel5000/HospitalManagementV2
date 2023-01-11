

namespace PointOfSalesV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.AppSections.Sellers)]
    public class SellerController : BaseController<Seller>
    {
        public SellerController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache, ISellerRepository sellerRepo) : base(appSettings, repositoryFactory,cache,sellerRepo, AppSections.Sellers)
        {
        }

        [HttpPost("GetComissionsReport")]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.COMISSIONSREPORT)]
        public virtual async Task<IActionResult> GetComissionsReport([FromBody] ComissionsSearch search)
        {
            try
            {
                var repo = this._repositoryFactory.GetCustomDataRepositories<ISellerRepository>();
                
                var invoices = search.ReportType == 0 ?
               await repo.SalesComissions(search) : await repo.PaymentsComissions(search);
                return Ok(new { status = 0, id = 0, data = invoices });
            }
            catch (Exception ex)
            {
                await SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });
            }


        }

        [HttpPost("ExportComissionsReport")]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.COMISSIONSREPORT)]
        public async Task<IActionResult> ExportComissionsReport([FromBody] ComissionsSearch search)
        {
            try
            {
                var repo = this._repositoryFactory.GetCustomDataRepositories<ISellerRepository>();

                var invoices = search.ReportType == 0 ?
               await repo.SalesComissions(search) :await repo.PaymentsComissions(search);


                string requestLanguage = "EN";
                var languageIdHeader = this.Request.Headers["languageid"];
                requestLanguage = languageIdHeader.FirstOrDefault() ?? "es";
                var excelData = ExportUtility.GetExcelData<ComissionDetail>(invoices.ComissionsByCyrrencies.SelectMany(x => x.Details), requestLanguage, this.languageKeys.ToList());
                var excelStream = ExcelImport.CreateXlsStream(
                    excelData.Item1,
                   excelData.Item2
                   );
                if (invoices != null && excelStream != null && excelStream.Length > 0)
                {

                    return File(excelStream.ToArray(), "application/octet-stream", $"{new Product().GetType().Name}-{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}.xls");
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