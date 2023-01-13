

namespace PointOfSalesV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.Controllers.PatientCheckup)]
    public class PatientCheckupController : BaseController<PatientCheckup>
    {
        
        readonly ISequenceManagerRepository sequence;
        readonly IPatientCheckupRepository patientCheckupRepository;
        public PatientCheckupController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory,cache,repositoryFactory.GetCustomDataRepositories<IPatientCheckupRepository>(), Enums.Controllers.PatientCheckup)
        {
            this.sequence = this._repositoryFactory.GetCustomDataRepositories<ISequenceManagerRepository>();
            this.patientCheckupRepository = this._repositoryFactory.GetCustomDataRepositories<IPatientCheckupRepository>();
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
                var data = await  _baseRepo.GetAllAsync<PatientCheckup>(x =>x.AsNoTracking()
                .Include(t=>t.Insurance)
                .Include(t=>t.InsurancePlan)
                .Include(t=>t.Appointment)
                .Include(t=>t.Doctor)
                .Include(t=>t.Patient)
                .Include(t=>t.CheckupPrescriptions).ThenInclude(p=>p.Product)
                .Include(t => t.Attachments)
                 , y => y.Active == true);
                return Ok(data);
               
            }

            catch (Exception ex)
            {
               await SaveException(ex);
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
                var data = await _baseRepo.GetAllAsync<PatientCheckup>(x => x.AsNoTracking()
               .Include(t => t.Insurance)
               .Include(t => t.InsurancePlan)
               .Include(t => t.Appointment)
               .Include(t => t.Doctor)
               .Include(t => t.Patient)
               .Include(t => t.CheckupPrescriptions).ThenInclude(p => p.Product)
               .Include(t => t.Attachments)
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
               await SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });
            }
        }
    }
}