

namespace PointOfSalesV2.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.AppSections.CustomerPayments)]
    public class CustomerPaymentController : BaseController<CustomerPayment>
    {
        public CustomerPaymentController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory,cache,null, AppSections.CustomerPayments)
        {
        }
        [HttpPost("PayInvoices")]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.ADD)]
       public async Task<IActionResult> PayInvoices([FromBody]InvoicesPaymentModel model) 
        {
            try
            {
                var repo = _repositoryFactory.GetCustomDataRepositories<ICustomerPaymentRepository>();
                var result = await repo.PayInvoices(model);
                return Ok(result);
            }

            catch (Exception ex)
            {
               await SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });
            }
        }


        [HttpGet("GetForPrint/{sequence}")]
        [ActionAuthorize(Operations.READ)]
        [EnableCors("AllowAllOrigins")]
        public virtual async Task<IActionResult> GetForPrint(string sequence)
        {
            try
            {
                
                var payments = await _baseRepo.GetAllAsync<CustomerPayment>(x => x.Include(t => t.Customer)
                .Include(t => t.Currency)
                , y => y.Active == true && y.Sequence.ToLower() == sequence);


                return Ok(new
                {
                    status = 0,
                    id = 0,
                    data = new object[] { new
                    {
                    payments.FirstOrDefault().Customer,
                    payments.FirstOrDefault().Currency,
                    payments.FirstOrDefault().Date,
                    PaidInvoices=payments
                    } }
                });
            }

            catch (Exception ex)
            {
                await SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });
            }

            

        }

        [HttpDelete("ReversePayment/{sequence}/{userId}")]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.DELETE)]
        public virtual async Task<IActionResult> ReversePayment(string sequence,string userId)
        {
            try
            {
                var result = await this._repositoryFactory.GetCustomDataRepositories<ICustomerPaymentRepository>().ReversePayment(sequence, userId);
                return Ok(result);
            }

            catch (Exception ex)
            {
               await SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });

            }

        }


        [HttpGet("GetReceipts/{branchOfficeId:long}/{customerId:long}/{currencyId:long}/{paymentTypeId:long}/{startDate}/{endDate}")]
        [ActionAuthorize(Operations.RECEIPTSREPORT)]
        [EnableCors("AllowAllOrigins")]
        public virtual async Task<IActionResult> GetReceipts(long branchOfficeId = 0, long customerId = 0, long currencyId = 0,long paymentTypeId=0, string startDate = "0", string endDate = "0")
        {
            DateTime? start = new DateTime();
            if (startDate != "0")
                start = Convert.ToDateTime(startDate);
            else
                start = null;
            DateTime? end = new DateTime();
            if (endDate != "0")
                end = Convert.ToDateTime(endDate);
            else
                end = null;
            try
            {

             
                var invoices = await base._repositoryFactory.GetCustomDataRepositories<ICustomerPaymentRepository>().IncomesReport(branchOfficeId,customerId,currencyId,paymentTypeId,start,end   );
                return Ok(new { status = 0, id = 0, data = invoices });
            }
            catch (Exception ex)
            {
                await SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });
            }


        }

        [HttpPost("ExportReceipts/{branchOfficeId:long}/{customerId:long}/{currencyId:long}/{paymentTypeId:long}/{startDate}/{endDate}")]
        [ActionAuthorize(Operations.RECEIPTSREPORT)]
        [EnableCors("AllowAllOrigins")]
        public virtual async Task<IActionResult> ExportReceipts(long branchOfficeId = 0, long customerId = 0, long currencyId = 0, long paymentTypeId = 0, string startDate = "0", string endDate = "0")
        {
            DateTime? start = new DateTime();
            if (startDate != "0")
                start = Convert.ToDateTime(startDate);
            else
                start = null;
            DateTime? end = new DateTime();
            if (endDate != "0")
                end = Convert.ToDateTime(endDate);
            else
                end = null;
            try
            {

              
                var invoices = await base._repositoryFactory.GetCustomDataRepositories<ICustomerPaymentRepository>().IncomesReport(branchOfficeId,customerId,currencyId,paymentTypeId,start,end);
                string requestLanguage = "EN";
                var languageIdHeader = this.Request.Headers["languageid"];
                requestLanguage = languageIdHeader.FirstOrDefault() ?? "es";
                var excelData = ExportUtility.GetExcelData<CustomerPayment>(invoices, requestLanguage, this.languageKeys.ToList());
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