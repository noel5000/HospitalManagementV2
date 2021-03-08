using Microsoft.EntityFrameworkCore;
using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PointOfSalesV2.Common.Enums;

namespace PointOfSalesV2.Repository
{
    public class AppointmentRepository : Repository<Appointment>, IAppointmentRepository
    {
        public AppointmentRepository(MainDataContext context) : base(context)
        {
        }

        public override Result<Appointment> Add(Appointment entity)
        {
            entity.State = (char)AppointmentStates.Scheduled;
            entity.TotalAmount = entity.BeforeTaxesAmount + entity.TaxesAmount;
            entity.PatientPaymentAmount = entity.TotalAmount - entity.InsuranceCoverageAmount;
            var exists = _Context.Appointment.Any(x => x.Active == true && x.DoctorId == entity.DoctorId &&
            x.State != (char)AppointmentStates.Nulled && x.Date == entity.Date);
            if (exists)
                return new Result<Appointment>(-1, -1, "appointmentExist_msg");
            return base.Add(entity);
        }

        public override Result<Appointment> Update(Appointment entity, bool getFromDb = true)
        {
            return base.Update(entity, getFromDb);
        }

        public override Result<Appointment> Remove(long id)
        {
            return base.Remove(id);
        }

        public async Task<List<Appointment>> GetAppointmentsByDay(DateTime date, long hospitalId, string doctorId, long? medicalSpeciality, long? patientId)
        {
            return await this._Context.Appointment.AsNoTracking().Include(x => x.MedicalSpeciality).Include(x => x.Hospital)
                 .Include(x => x.Insurance).Include(x => x.Product).Include(x => x.Patient).Include(x => x.InsurancePlan)
                 .Include(x => x.Doctor).Include(x => x.Currency).Where(x => x.Active == true && (hospitalId > 0 ? x.HospitalId == hospitalId : x.HospitalId > 0) &&
                       (medicalSpeciality.HasValue && medicalSpeciality.Value > 0 ? x.MedicalSpecialityId == medicalSpeciality : x.MedicalSpecialityId > 0) &&
                       (patientId.HasValue && patientId.Value > 0 ? x.PatientId == patientId : x.PatientId > 0) &&
                       (!string.IsNullOrEmpty(doctorId) ? x.DoctorId == (new Guid(doctorId)) : x.DoctorId != new Guid("00000000-0000-0000-0000-000000000000")) &&
                       (x.Date.Year == date.Year) && x.Date.Month == date.Month && x.Date.Day == date.Day
                   )
                 .Select(x => new Appointment()
                 {
                     Active = x.Active,
                     BeforeTaxesAmount = x.BeforeTaxesAmount,
                     InsuranceCoverageAmount = x.InsuranceCoverageAmount,
                     PatientPaymentAmount = x.PatientPaymentAmount,
                     TaxesAmount = x.TaxesAmount,
                     TotalAmount = x.TotalAmount,
                     CurrencyId = x.CurrencyId,
                     Date = x.Date,
                     DoctorName = $"{x.Doctor.Name ?? ""} ${x.Doctor.LastName ?? ""}",
                     DoctorId = x.DoctorId,
                     HospitalId = x.HospitalId,
                     Id = x.Id,
                     InsuranceId = x.InsuranceId,
                     InsuranceName = x.InsuranceId.HasValue ? x.Insurance.Name ?? "" : "",
                     InsurancePlanId = x.InsurancePlanId,
                     InsurancePlanName = x.InsurancePlanId.HasValue ? x.InsurancePlan.Name ?? "" : "",
                     MedicalSpecialityId = x.MedicalSpecialityId,
                     MedicalSpecialityName = x.MedicalSpecialityId.HasValue ? x.MedicalSpeciality.Name ?? "" : "",
                     SpecialityName = x.MedicalSpecialityId.HasValue ? x.MedicalSpeciality.Name ?? "" : "",
                     CurrencyName = x.Currency.Name,
                     HospitalName = x.Hospital.Name,
                     PatientName = x.Patient.Name,
                     ProductName = x.Product.Name,
                     State = x.State,
                     ProductId = x.ProductId,
                     PatientId = x.PatientId,
                 })
                 .ToListAsync();
        }

        public async Task<List<Appointment>> GetAppointmentsByMonth(DateTime date, long hospitalId, string doctorId, long? medicalSpeciality, long? patientId)
        {
            return await this._Context.Appointment.AsNoTracking().Include(x => x.MedicalSpeciality).Include(x => x.Hospital)
                 .Include(x => x.Insurance).Include(x => x.Product).Include(x => x.Patient).Include(x => x.InsurancePlan)
                 .Include(x => x.Doctor).Include(x => x.Currency).Where(x => x.Active == true && (hospitalId>0?x.HospitalId == hospitalId:x.HospitalId>0) &&
                          (medicalSpeciality.HasValue && medicalSpeciality.Value > 0 ? x.MedicalSpecialityId == medicalSpeciality : x.MedicalSpecialityId > 0) &&
                       (patientId.HasValue && patientId.Value > 0 ? x.PatientId == patientId : x.PatientId > 0) &&
                       (!string.IsNullOrEmpty(doctorId) ? x.DoctorId == (new Guid(doctorId)) : x.DoctorId != new Guid("00000000-0000-0000-0000-000000000000")) &&
                       (x.Date.Month == date.Month) && x.Date.Year == date.Year
                   )
                 .Select(x => new Appointment()
                 {
                     Active = x.Active,
                     BeforeTaxesAmount = x.BeforeTaxesAmount,
                     InsuranceCoverageAmount = x.InsuranceCoverageAmount,
                     PatientPaymentAmount = x.PatientPaymentAmount,
                     TaxesAmount = x.TaxesAmount,
                     TotalAmount = x.TotalAmount,
                     CurrencyId = x.CurrencyId,
                     Date = x.Date,
                     DoctorName = $"{x.Doctor.Name ?? ""} ${x.Doctor.LastName ?? ""}",
                     DoctorId = x.DoctorId,
                     HospitalId = x.HospitalId,
                     Id = x.Id,
                     InsuranceId = x.InsuranceId,
                     InsuranceName = x.InsuranceId.HasValue ? x.Insurance.Name ?? "" : "",
                     InsurancePlanId = x.InsurancePlanId,
                     InsurancePlanName = x.InsurancePlanId.HasValue ? x.InsurancePlan.Name ?? "" : "",
                     MedicalSpecialityId = x.MedicalSpecialityId,
                     MedicalSpecialityName = x.MedicalSpecialityId.HasValue ? x.MedicalSpeciality.Name ?? "" : "",
                     SpecialityName = x.MedicalSpecialityId.HasValue ? x.MedicalSpeciality.Name ?? "" : "",
                     CurrencyName = x.Currency.Name,
                     HospitalName = x.Hospital.Name,
                     PatientName = x.Patient.Name,
                     ProductName = x.Product.Name,
                     State = x.State,
                     ProductId = x.ProductId,
                     PatientId = x.PatientId,
                 })
                 .ToListAsync();
        }
    }
}
