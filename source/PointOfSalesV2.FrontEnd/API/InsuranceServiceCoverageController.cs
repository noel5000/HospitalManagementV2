﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PointOfSalesV2.FrontEnd.Security;
using PointOfSalesV2.Common;
using PointOfSalesV2.Entities; using Microsoft.Extensions.Caching.Memory;
using PointOfSalesV2.Entities.Model;
using PointOfSalesV2.Repository;
using static PointOfSalesV2.Common.Enums;
using Microsoft.AspNetCore.Cors;

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
        [EnableQuery()]
        [EnableCors("AllowAllOrigins")]
        public override IActionResult Get()
        {
            try
            {
                var data = _baseRepo.GetAll<InsuranceServiceCoverage>(x => x.Include(t => t.Insurance)
                .Include(t=>t.Product)
                 , y => y.Active == true);
                return Ok(data);
               
            }

            catch (Exception ex)
            {
                SaveException(ex);
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
                SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });
            }
        }






        [HttpPost("ExportToExcel")]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.EXPORT)]
        public override IActionResult ExportToExcel()
        {
            try
            {
                var data = _baseRepo.GetAll<InsuranceServiceCoverage>(x => x.Include(t => t.Insurance).Include(t=>t.Product)
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
                SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });
            }
        }
    }
}