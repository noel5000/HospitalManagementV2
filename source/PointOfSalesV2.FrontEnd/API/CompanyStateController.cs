

namespace PointOfSalesV2.FrontEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.AppSections.ResultState)]
    public class CompanyStateController : ControllerBase
    {
        protected readonly IDataRepositoryFactory _repositoryFactory;
        protected readonly IOptions<AppSettings> _appSettings;
        protected readonly IMemoryCache _cache;
        protected readonly IBase<LanguageKey> languageKeysRepo;
        protected IEnumerable<LanguageKey> languageKeys;
        IInvoiceRepository _customRepo;
        public CompanyStateController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache)
        {
            this._customRepo = repositoryFactory.GetCustomDataRepositories<IInvoiceRepository>();
            _repositoryFactory = repositoryFactory;
            _appSettings = appSettings;
            _cache = cache;
            this.languageKeysRepo = repositoryFactory.GetDataRepositories<LanguageKey>();
            this.languageKeys = _cache.Get<IEnumerable<LanguageKey>>("languageKeysMem");
            if (this.languageKeys == null)
            {
                this.languageKeys = this.languageKeysRepo.GetAll(x => x, y => y.Active == true).Data;
                this._cache.Set("languageKeysMem", this.languageKeys, DateTime.Now.AddHours(24));
            }
        }



        [HttpGet("GetState/{startDate}/{endDate}")]
        [ActionAuthorize(Operations.READ)]
        [EnableCors("AllowAllOrigins")]
        public virtual async Task<IActionResult> GetState(long branchOfficeId = 0, long customerId = 0,long currencyId=0, string startDate="0",string endDate="0")
        {
            try
            {
                
                var invoices = await _customRepo.GetCompanyStatus(
                    startDate == "0" ? DateTime.MinValue : Convert.ToDateTime(startDate),
                   endDate == "0" ? DateTime.Now : Convert.ToDateTime(endDate));
                var result = new List<CompanyStateReport>();
                invoices.GroupBy(x => x.CurrencyCode).ToList().ForEach(x => {
                    result.Add(new CompanyStateReport()
                    {
                        TotalCompanyOwedAmount = x.Sum(r => r.CompanyOwedAmount),
                        TotalCustomersOwedAmount = x.Sum(r => r.CustomersOwedAmount),
                        TotalIncomesAmount = x.Sum(r => r.IncomeAmount),
                        TotalOutComesAmount = x.Sum(r => r.OutcomeAmount),
                        CurrencyCode = x.FirstOrDefault()?.CurrencyName ?? "",
                        Data = x.ToList()
                    });
                });
                return Ok(new { status = 0, id = 0, data = result });
            }
            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });
            }


        }

        [HttpPost("ExportState/{startDate}/{endDate}")]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.EXPORT)]
        public  async Task<IActionResult> ExportState( string startDate = "0", string endDate = "0")
        {

            try
            {
                
                var invoices = await _customRepo.GetCompanyStatus(
                   startDate == "0" ? DateTime.MinValue : Convert.ToDateTime(startDate),
                   endDate == "0" ? DateTime.Now : Convert.ToDateTime(endDate));


                string requestLanguage = "EN";
                var languageIdHeader = this.Request.Headers["languageid"];
                requestLanguage = languageIdHeader.FirstOrDefault() ?? "es";
                var excelData = ExportUtility.GetExcelData<CompanyStateModel>(invoices, requestLanguage, this.languageKeys.ToList());
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
                return Ok(new { status = -1, message = ex.Message });
            }

        }


    }
}