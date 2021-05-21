using System;
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
    [ControllerAuthorize(Common.Enums.AppSections.PatientCheckup)]
    public class PatientCheckupController : BaseController<PatientCheckup>
    {
        
        readonly ISequenceManagerRepository sequence;
        readonly IPatientCheckupRepository patientCheckupRepository;
        public PatientCheckupController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory,cache,repositoryFactory.GetCustomDataRepositories<IPatientCheckupRepository>(), AppSections.PatientCheckup)
        {
            this.sequence = this._repositoryFactory.GetCustomDataRepositories<ISequenceManagerRepository>();
            this.patientCheckupRepository = this._repositoryFactory.GetCustomDataRepositories<IPatientCheckupRepository>();
        }

        [HttpGet]
        [ActionAuthorize(Operations.READALL)]
        [EnableQuery()]
        [EnableCors("AllowAllOrigins")]
        public override IActionResult Get()
        {
            try
            {
                var data = _baseRepo.GetAll<PatientCheckup>(x =>x.AsNoTracking().Include(t=>t.Insurance)
                .Include(t=>t.InsurancePlan).Include(t=>t.Appointment).Include(t=>t.Doctor).Include(t=>t.Patient)
                 , y => y.Active == true);
                return Ok(data);
               
            }

            catch (Exception ex)
            {
                SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });
            }
        }
        [HttpGet("GetPatientHistory/{patientId:long}")]
        [ActionAuthorize(Operations.READALL)]
        [EnableCors("AllowAllOrigins")]
        public async Task<IActionResult> GetPatientHistory(long patientId) 
        {
            try
            {
                var data = await patientCheckupRepository.GetPatientHistory(patientId);
                return Ok(new {status=0,message="ok_msg", data });

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
                var data = _baseRepo.GetAll<PatientCheckup>(x => x.AsNoTracking().Include(t => t.Insurance)
               .Include(t => t.InsurancePlan).Include(t => t.Appointment).Include(t => t.Doctor).Include(t => t.Patient)
                , y => y.Active == true);
                string requestLanguage = "EN";
                var languageIdHeader = this.Request.Headers["languageid"];
                requestLanguage = languageIdHeader.FirstOrDefault() ?? "ES";
                var excelData = ExportUtility.GetExcelData<PatientCheckup>(data, requestLanguage, this.languageKeys.ToList());
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
                SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });
            }
        }
    }
}