

namespace PointOfSalesV2.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.AppSections.Invoices)]
    public class InvoiceController : BaseController<Invoice>
    {
        IInvoiceRepository _customRepo;
        public InvoiceController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory,cache, repositoryFactory.GetCustomDataRepositories<IInvoiceRepository>(), AppSections.Invoices)
        {
            this._customRepo = repositoryFactory.GetCustomDataRepositories<IInvoiceRepository>();
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
                var data = await _baseRepo.GetAllAsync<Invoice>(x => x.AsNoTracking()
                .Include(i=>i.BranchOffice).Include(i => i.Patient).Include(i => i.Currency).Include(i => i.Insurance)
                .Include(i => i.InsurancePlan).Include(i => i.Appointment).Include(i => i.Seller)
                , y => y.Active == true);
                return Ok(data);
            }

            catch (Exception ex)
            {
                await SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });
            }
        }

        [EnableCors("AllowAllOrigins")]
        [HttpGet("GetForPrint/{id:long}")]
        [ActionAuthorize(Operations.READ)]
        public virtual async Task<IActionResult> GetForPrint(long id)
        {
            try
            {
              
                var invoice = (await _baseRepo.GetAllAsync<Invoice>(x => x.AsNoTracking().Include(i => i.Patient)
                .Include(i => i.BranchOffice).Include(i => i.Seller).Include(i => i.Currency).Include(i => i.TRNControl)
                .Where(y => y.Active == true && y.Id == id))).FirstOrDefault();
                invoice.InvoiceDetails =(await _repositoryFactory.GetDataRepositories<InvoiceDetail>().GetAllAsync<InvoiceDetail>(x =>
                x.Include(i => i.Product).Include(i => i.Unit), y => y.Active == true && y.InvoiceId == id)).ToList();
                return Ok(new { status = 0, id, data = new Invoice[] { invoice } });
            }

            catch (Exception ex)
            {
                await SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });
            }

          
          
        }

        [EnableCors("AllowAllOrigins")]
        [HttpGet("GetByInvoiceNumber/{invoiceNumber}")]
        [ActionAuthorize(Operations.READ)]
        public virtual async Task<IActionResult> GetByInvoiceNumber(string invoiceNumber)
        {
            try
            {
                var validStates = new char[] { ((char)Enums.BillingStates.Paid), ((char)Enums.BillingStates.FullPaid) };
              
                var invoice = (await _baseRepo.GetAllAsync<Invoice>(x => x.AsNoTracking().Include(i => i.Patient)
                .Include(i => i.BranchOffice).Include(i => i.Seller).Include(i => i.Currency).Include(i => i.TRNControl)
                .Where(y => y.Active == true && validStates.Contains(y.State) && y.InvoiceNumber.ToLower() == invoiceNumber.ToLower()))).FirstOrDefault();
                if (invoice == null)
                    return Ok(new { status = -1, message = "notFound_msg" });
                invoice.InvoiceDetails =(await _repositoryFactory.GetDataRepositories<InvoiceDetail>().GetAllAsync<InvoiceDetail>(x =>
                x.Include(i => i.Product).Include(i => i.Unit), y => y.Active == true && y.InvoiceId == invoice.Id)).ToList();
                return Ok(new { status = 0, id = 0, data = new Invoice[] { invoice } });
            }

            catch (Exception ex)
            {
                await SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });
            };

            

        }

        [EnableCors("AllowAllOrigins")]
        [HttpPost("BillQuote/{id:long}")]
        [ActionAuthorize(Operations.UPDATE)]
        public virtual async Task<IActionResult> BillQuote(long id)
        {
            try
            {
               
                var result = await _customRepo.BillQuote(id);

                return Ok(result);
            }

            catch (Exception ex)
            {
                await SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });
            }
         

        }

        [EnableCors("AllowAllOrigins")]
        [HttpGet("GetInvoicesToPay/{branchOfficeId:long}/{customerId:long}/{currencyId:long}")]
        [ActionAuthorize(Operations.READALL)]
        public virtual async Task<IActionResult> GetInvoicesToPay(long branchOfficeId=0,long customerId=0, long currencyId = 0)
        {
            try
            {
              
                var invoices = await _customRepo.GetInvoicesToPay(branchOfficeId,currencyId,customerId);
                return Ok(new { status = 0, id = 0, data = invoices });
            }
            catch (Exception ex)
            {
                await SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });
            }
        

           
        }

        [EnableCors("AllowAllOrigins")]
        [HttpGet("GetAccountReceivables/{branchOfficeId:long}/{customerId:long}/{currencyId:long}/{startDate}/{endDate}")]
        [ActionAuthorize(Operations.ACCOUNTRECEIVABLES)]
        public virtual async Task<IActionResult> GetAccountReceivables(long branchOfficeId = 0, long customerId = 0,long currencyId=0, string startDate="0",string endDate="0")
        {
            try
            {
             
                var invoices = await _customRepo.GetAccountsReceivable(
                    startDate == "0" ? DateTime.MinValue : Convert.ToDateTime(startDate),
                    endDate == "0" ? DateTime.Now : Convert.ToDateTime(endDate),
                   customerId, currencyId, null, branchOfficeId);
                return Ok(new { status = 0, id = 0, data = invoices });
            }
            catch (Exception ex)
            {
                await SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });
            }
           


        }

        [EnableCors("AllowAllOrigins")]
        [HttpGet("GetInsuranceCoverages/{branchOfficeId:long}/{currencyId:long}/{insuranceId:long}/{insurancePlanId:long}/{startDate}/{endDate}")]
        [ActionAuthorize(Operations.ACCOUNTRECEIVABLES)]
        public virtual async Task<IActionResult> GetInsuranceCoverages(long branchOfficeId = 0, long currencyId = 0,long insuranceId=0,long insurancePlanId=0, string startDate = "0", string endDate = "0")
        {
            try
            {
               
                var invoices = await _customRepo.GetInsuranceCoverages(
                   startDate == "0" ? DateTime.MinValue : Convert.ToDateTime(startDate),
                   endDate == "0" ? DateTime.Now : Convert.ToDateTime(endDate),
                   insuranceId,
                   insurancePlanId,
                   currencyId,
                   branchOfficeId);
                return Ok(new { status = 0, id = 0, data = invoices });
            }
            catch (Exception ex)
            {
                await SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });
            }


        }

        [EnableCors("AllowAllOrigins")]
        [HttpPost("GetInsuranceCoveragesExport/{branchOfficeId:long}/{currencyId:long}/{insuranceId:long}/{insurancePlanId:long}/{startDate}/{endDate}")]
        [ActionAuthorize(Operations.ACCOUNTRECEIVABLES)]
        public virtual async Task<IActionResult> GetInsuranceCoveragesExport(long branchOfficeId = 0, long currencyId = 0, long insuranceId = 0, long insurancePlanId = 0, string startDate = "0", string endDate = "0")
        {
            try
            {
                
                var invoices = await _customRepo.GetInsuranceCoverages(
                    startDate == "0" ? DateTime.MinValue : Convert.ToDateTime(startDate),
                   endDate == "0" ? DateTime.Now : Convert.ToDateTime(endDate),
                    insuranceId,
                    insurancePlanId,
                    currencyId,
                    branchOfficeId);
                return Ok(new { status = 0, id = 0, data = invoices });
            }
            catch (Exception ex)
            {
                await SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });
            }


        }

        [HttpPost("ExportAccountReceivables/{branchOfficeId:long}/{customerId:long}/{currencyId:long}/{startDate}/{endDate}")]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.ACCOUNTRECEIVABLES)]
        public async Task<IActionResult> ExportAccountReceivables(long branchOfficeId = 0, long customerId = 0, long currencyId = 0, string startDate = "0", string endDate = "0")
        {

            try
            {
                
                var invoices = await _customRepo.GetAccountsReceivable(
                   startDate == "0" ? DateTime.MinValue : Convert.ToDateTime(startDate),
                    endDate == "0" ? DateTime.Now : Convert.ToDateTime(endDate),
                   customerId, currencyId, null, branchOfficeId);


                string requestLanguage = "EN";
                var languageIdHeader = this.Request.Headers["languageid"];
                requestLanguage = languageIdHeader.FirstOrDefault() ?? "es";
                var excelData = ExportUtility.GetExcelData<Invoice>(invoices, requestLanguage, this.languageKeys.ToList());
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


        [EnableCors("AllowAllOrigins")]
        [HttpGet("GetSales/{branchOfficeId:long}/{customerId:long}/{currencyId:long}/{startDate}/{endDate}")]
        [ActionAuthorize(Operations.SALESREPORT)]
        public virtual async Task<IActionResult> GetSales(long branchOfficeId = 0, long customerId = 0, long currencyId = 0, string startDate = "0", string endDate = "0")
        {
            try
            {
                
                var invoices = await _customRepo.GetSales(
                    startDate == "0" ? DateTime.MinValue : Convert.ToDateTime(startDate),
                    endDate == "0" ? DateTime.Now : Convert.ToDateTime(endDate),
                    customerId, currencyId, null, branchOfficeId);
                return Ok(new { status = 0, id = 0, data = invoices });
            }
            catch (Exception ex)
            {
                await SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });
            }


        }

        [HttpPost("ExportSales/{branchOfficeId:long}/{customerId:long}/{currencyId:long}/{startDate}/{endDate}")]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.SALESREPORT)]
        public async Task<IActionResult> ExportSales(long branchOfficeId = 0, long customerId = 0, long currencyId = 0, string startDate = "0", string endDate = "0")
        {

            try
            {
                
                var invoices = await _customRepo.GetSales(
                    startDate == "0" ? DateTime.MinValue : Convert.ToDateTime(startDate),
                   endDate == "0" ? DateTime.Now : Convert.ToDateTime(endDate),
                    customerId, currencyId, null, branchOfficeId);


                string requestLanguage = "EN";
                var languageIdHeader = this.Request.Headers["languageid"];
                requestLanguage = languageIdHeader.FirstOrDefault() ?? "es";
                var excelData = ExportUtility.GetExcelData<Invoice>(invoices, requestLanguage, this.languageKeys.ToList());
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