using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PointOfSalesV2.Api.Security;
using PointOfSalesV2.Common;
using PointOfSalesV2.Entities;
using Microsoft.Extensions.Caching.Memory;
using PointOfSalesV2.Entities.Model;
using PointOfSalesV2.Repository;
using static PointOfSalesV2.Common.Enums;
using Microsoft.AspNetCore.Cors;

namespace PointOfSalesV2.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.AppSections.Customers)]
    public class CustomerController : BaseController<Customer>
    {
        readonly ISequenceManagerRepository sequence;
        public CustomerController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) 
            : base(appSettings, repositoryFactory, cache, repositoryFactory.GetCustomDataRepositories<ICustomerRepository>(), AppSections.Customers)
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
                var data = await _baseRepo.GetAllAsync<Customer>(x => x.AsNoTracking()
                .Include(x => x.Currency)
                .Include(x => x.TRNControl)
                .Include(x=>x.Zone)
                .Include(x=>x.Insurance)
                .Include(x=>x.InsurancePlan)
                .Where(y => y.Active == true));
                return Ok(data);
            }

            catch (Exception ex)
            {
               await SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });
            }
        }


        [HttpPost]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.ADD)]
        public override async Task<IActionResult> Post([FromBody] Customer model)
        {
            try
            {
                var activeEntity = model as ICommonData;
                if (activeEntity != null)
                {
                    activeEntity.Active = true;
                    model = activeEntity as Customer;
                    model.Code = await sequence.CreateSequence(SequenceTypes.Customers);
                }
                var result =await _baseRepo.AddAsync(model);

                return Ok(result);
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
                var data = await _baseRepo.GetAllAsync<Customer>(x => x.AsNoTracking()
               .Include(x => x.Currency)
               .Include(x => x.TRNControl)
               .Include(x => x.Zone)
               .Include(x => x.Insurance)
               .Include(x => x.InsurancePlan)
               .Where(y => y.Active == true));
                string requestLanguage = "EN";
                var languageIdHeader = this.Request.Headers["languageid"];
                requestLanguage = languageIdHeader.FirstOrDefault() ?? "es";
                var excelData = ExportUtility.GetExcelData<Customer>(data, requestLanguage, this.languageKeys.ToList());
                var excelStream = ExcelImport.CreateXlsStream(
                    excelData.Item1,
                   excelData.Item2
                   );
                if (data != null && excelStream != null && excelStream.Length > 0)
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

        [HttpPost("AccountStateExport/{customerId:long}")]
        [ActionAuthorize(Operations.ACCOUNTSTATEREPORT)]
        [EnableCors("AllowAllOrigins")]
        public async Task<IActionResult> AccountStateExport(long customerId)
        {
            try
            {
                var data = await _repositoryFactory.GetCustomDataRepositories<ICustomerBalanceRepository>().CustomerState(customerId);
                string requestLanguage = "EN";
                var languageIdHeader = this.Request.Headers["languageid"];
                requestLanguage = languageIdHeader.FirstOrDefault() ?? "es";
                var excelData = ExportUtility.GetExcelData<CustomerStateModel>(data.Data, requestLanguage, this.languageKeys.ToList());
                var excelStream = ExcelImport.CreateXlsStream(
                    excelData.Item1,
                   excelData.Item2
                   );
                if (data != null && excelStream != null && excelStream.Length > 0)
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

        [HttpGet("AccountState/{customerId:long}")]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.ACCOUNTSTATEREPORT)]
       public async Task<IActionResult> AccountState(long customerId)
        {
            try
            {
                var data = await _repositoryFactory.GetCustomDataRepositories<ICustomerBalanceRepository>().CustomerState(customerId);
                return Ok(new { status = 0, data });
            }

            catch (Exception ex)
            {
               await SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });
            }
        }
    }
}