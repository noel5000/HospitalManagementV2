using Microsoft.EntityFrameworkCore;
using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSalesV2.Repository
{
    public class AppointmentRepository : Repository<Appointment>, IAppointmentRepository
    {
        public AppointmentRepository(MainDataContext context) : base(context)
        {
        }

        public async Task<List<Appointment>> GetAppointmentsByDay(DateTime date, long hospitalId, string doctorId, long? medicalSpeciality, long? patientId)
        {
            return await this._Context.Appointment.AsNoTracking().Include(x => x.MedicalSpeciality).Include(x=>x.Hospital)
                 .Include(x => x.Insurance).Include(x => x.Product).Include(x => x.Patient).Include(x => x.InsurancePlan)
                 .Include(x => x.Doctor).Include(x => x.Currency).Where(x => x.Active == true && x.HospitalId == hospitalId &&
                       (medicalSpeciality.HasValue && medicalSpeciality.Value > 0 ? x.MedicalSpecialityId == medicalSpeciality : x.MedicalSpecialityId > 0) &&
                       (patientId.HasValue && patientId.Value > 0 ? x.PatientId == patientId : x.PatientId > 0) &&
                       (!string.IsNullOrEmpty(doctorId) ? x.DoctorId == (new Guid(doctorId)) : x.DoctorId != new Guid("00000000-0000-0000-0000-000000000000")) &&
                       (x.Date.Year == date.Year) && x.Date.Month==date.Month && x.Date.Day==date.Day
                   ).ToListAsync();
        }

        public async Task<List<Appointment>> GetAppointmentsByMonth(DateTime date, long hospitalId, string doctorId, long? medicalSpeciality, long? patientId)
        {
            return await this._Context.Appointment.AsNoTracking().Include(x => x.MedicalSpeciality).Include(x => x.Hospital)
                 .Include(x => x.Insurance).Include(x => x.Product).Include(x => x.Patient).Include(x => x.InsurancePlan)
                 .Include(x => x.Doctor).Include(x => x.Currency).Where(x => x.Active == true && x.HospitalId == hospitalId &&
                          (medicalSpeciality.HasValue && medicalSpeciality.Value > 0 ? x.MedicalSpecialityId == medicalSpeciality : x.MedicalSpecialityId > 0) &&
                       (patientId.HasValue && patientId.Value > 0 ? x.PatientId == patientId : x.PatientId > 0) &&
                       (!string.IsNullOrEmpty(doctorId) ? x.DoctorId == (new Guid(doctorId)) : x.DoctorId != new Guid("00000000-0000-0000-0000-000000000000")) &&
                       (x.Date.Month == date.Month) && x.Date.Year == date.Year
                   ).ToListAsync();
        }
    }
}
