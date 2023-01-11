

namespace PointOfSalesV2.Repository
{
    public interface IAppointmentRepository : IBase<Appointment>
    {
        Task<List<Appointment>> GetAppointmentsByDay(DateTime date,long hospitalId, string doctorId, long? medicalSpeciality, long? patientId,string type=null);
        Task<List<Appointment>> GetAppointmentsByMonth(DateTime date, long hospitalId, string doctorId, long? medicalSpeciality, long? patientId,string type=null);
    }
}
