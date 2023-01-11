

namespace PointOfSalesV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.AppSections.Appointment)]
    public class AppointmentController : BaseController<Appointment>
    {
        protected readonly IAppointmentRepository appointmentRepository;
        public AppointmentController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory, cache, repositoryFactory.GetCustomDataRepositories<IAppointmentRepository>(), AppSections.Appointment)
        {
            this.appointmentRepository = this._repositoryFactory.GetCustomDataRepositories<IAppointmentRepository>();
        }
        [ActionAuthorize(Operations.READALL)]
        [EnableQuery]
        [Microsoft.AspNetCore.OData.Routing.Attributes.ODataAttributeRouting]
        [EnableCors("AllowAllOrigins")]
        public override async Task<IActionResult> Get()
        {
            try
            {
                var data = await _baseRepo.GetAllAsync<Appointment>(x => x.AsNoTracking()
                .Include(x => x.Hospital)
                .Include(x => x.Patient)
                .Include(x => x.Insurance)
                .Include(x => x.InsurancePlan)
                .Include(x => x.Currency)
                .Include(x => x.Details).ThenInclude(x => x.Doctor)
                .Include(x => x.Details).ThenInclude(x => x.Product)
                .Include(x => x.Details).ThenInclude(x => x.MedicalSpeciality)
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
        [HttpGet("GetAppointmentsByDay/{date}/{hospitalId:long}/{doctorId}/{medicalSpeciality:long?}/{patientId:long?}/{type}")]
        public async Task<IActionResult> GetAppointmentsByDay(DateTime date, long hospitalId, string doctorId, long? medicalSpeciality, long? patientId,string type)
        {
            try
            {
                doctorId = !string.IsNullOrEmpty(doctorId) && doctorId != "null" ? doctorId : null;
                var appointments = await appointmentRepository.GetAppointmentsByDay(date, hospitalId, doctorId, medicalSpeciality, patientId,type);
                var data = new Result<Appointment>(0, 0, "ok_msg", appointments);
                return Ok(data);
            }

            catch (Exception ex)
            {
              await  SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });
            }
        }
        [EnableCors("AllowAllOrigins")]
        [HttpGet("GetAppointmentsByMonth/{date}/{hospitalId:long}/{doctorId}/{medicalSpeciality:long?}/{patientId:long?}/{type}")]
        public async Task<IActionResult> GetAppointmentsByMonth(DateTime date, long hospitalId, string doctorId, long? medicalSpeciality, long? patientId, string type)
        {
            try
            {
                doctorId = doctorId != null && doctorId == "null" ? "" : doctorId;
                var appointments = await appointmentRepository.GetAppointmentsByMonth(date, hospitalId, doctorId, medicalSpeciality, patientId,type);
                var data = new Result<Appointment>(0, 0, "ok_msg", appointments);
                return Ok(data);
            }

            catch (Exception ex)
            {
               await SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });
            }
        }
    }
}