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

        public override async Task<Result<Appointment>> GetAsync(long id)
        {
            var item = await this._Context.Appointments.AsNoTracking().Include(x => x.Hospital)
                 .Include(x => x.Insurance).Include(x => x.Patient).Include(x => x.InsurancePlan)
                 .Include(x => x.Currency).Where(x => x.Active == true && x.Id == id)
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
                     HospitalId = x.HospitalId,
                     Id = x.Id,
                     InsuranceId = x.InsuranceId,
                     InsuranceName = (x.InsuranceId.HasValue ? x.Insurance.Name : ""),
                     InsurancePlanId = x.InsurancePlanId,
                     InsurancePlanName = (x.InsurancePlanId.HasValue ? x.InsurancePlan.Name : ""),
                     CurrencyName = x.Currency.Name,
                     HospitalName = x.Hospital.Name,
                     PatientName = x.Patient.Name,
                     State = x.State,
                     PatientId = x.PatientId,
                     CreatedBy = x.CreatedBy,
                     Currency = x.Currency,
                     Hospital = x.Hospital,
                     Insurance = x.Insurance,
                     InsurancePlan = x.InsurancePlan,
                     Patient = x.Patient
                 })
                 .FirstOrDefaultAsync();
            item.Details = await _Context.AppointmentDetails.AsNoTracking()
                .Include(x => x.Doctor)
                .Include(x => x.Product)
                .Include(x => x.MedicalSpeciality)
                .Include(x => x.Currency).Where(x => x.Active == true && x.AppointmentId == id).Select(d => new AppointmentDetail()
                {
                    Active = d.Active,
                    AppointmentId = d.AppointmentId,
                    BeforeTaxesAmount = d.BeforeTaxesAmount,
                    InsuranceCoverageAmount = d.InsuranceCoverageAmount,
                    Id = d.Id,
                    CurrencyId = d.CurrencyId,
                    PatientPaymentAmount = d.PatientPaymentAmount,
                    TaxesAmount = d.TaxesAmount,
                    TotalAmount = d.TotalAmount,
                    CreatedBy = d.CreatedBy,
                    Date = d.Date,
                    CreatedByName = d.CreatedByName,
                    CreatedDate = d.CreatedDate,
                    Currency = d.Currency,
                    DoctorName = $"{(d.Doctor != null ? d.Doctor.FullName : "")}",
                    DoctorId = d.DoctorId,
                    MedicalSpecialityId = d.MedicalSpecialityId,
                    MedicalSpecialityName = (d.MedicalSpecialityId.HasValue ? d.MedicalSpeciality.Name : ""),
                    SpecialityName = (d.MedicalSpecialityId.HasValue ? d.MedicalSpeciality.Name : ""),
                    ProductName = (d.Product != null ? d.Product.Name : ""),
                    Type = d.Type,
                    ProductId = d.ProductId,
                    CurrencyName = d.Currency.Name,
                    Doctor = d.Doctor,
                    MedicalSpeciality = d.MedicalSpeciality,
                    ModifiedBy = d.ModifiedBy,
                    ModifiedByName = d.ModifiedByName,
                    ModifiedDate = d.ModifiedDate,
                    Product = d.Product,
                }).ToListAsync();
            return new Result<Appointment>(item.Id, 0, "ok_msg", new List<Appointment>() { item });
        }

        public override async Task<Result<Appointment>> AddAsync(Appointment entity)
        {
            entity.Details = entity.Details == null ? new List<AppointmentDetail>() : entity.Details;

            if (entity.Details.Count == 0)
                return new Result<Appointment>(-1, -1, "emptyAppointment_msg");

            entity.Details.ForEach(d =>
            {
                d.Product = null;
                d.Doctor = null;
                d.Currency = null;
                d.Appointment = null;
                d.Date = entity.Date;
                d.Active = true;
                d.MedicalSpeciality = null;
                d.TotalAmount = d.BeforeTaxesAmount + d.TaxesAmount;
                d.PatientPaymentAmount = d.TotalAmount - d.InsuranceCoverageAmount;
            });

            var doctorConsultations = entity.Details?.Where(x => x.Type == (char)AppointmentTypes.Consultation && x.DoctorId.HasValue).ToList();
            if (doctorConsultations.Count > 1)
                return new Result<Appointment>(-1, -1, "onlyOneConsultationPerAppointment_msg");

            entity.Active = true;
            entity.State = (char)AppointmentStates.Scheduled;
            entity.BeforeTaxesAmount = entity.Details.Sum(x => x.BeforeTaxesAmount);
            entity.TaxesAmount = entity.Details.Sum(x => x.TaxesAmount);
            entity.InsuranceCoverageAmount = entity.Details.Sum(x => x.InsuranceCoverageAmount);
            entity.TotalAmount = entity.BeforeTaxesAmount + entity.TaxesAmount;
            entity.PatientPaymentAmount = entity.TotalAmount - entity.InsuranceCoverageAmount;
            bool exists = false;

            doctorConsultations.ForEach(d =>
            {

                if (_Context.AppointmentDetails.AsNoTracking().Include(x => x.Appointment).Any(x => x.Active == true && x.DoctorId == d.DoctorId &&
                   x.Appointment.State != (char)AppointmentStates.Nulled && x.Date == entity.Date))
                    exists = true;
            });

            if (exists)
                return new Result<Appointment>(-1, -1, "appointmentExist_msg");

            var details = entity.Details;
            entity.Details = null;
            entity.Patient = null;
            entity.Hospital = null;
            entity.Insurance = null;
            entity.InsurancePlan = null;
            entity.Currency = null;
            var insertResult = await base.AddAsync(entity);
            if (insertResult.Status >= 0)
            {
                details.ForEach(d =>
                {
                    d.AppointmentId = insertResult.Id;
                    d.CurrencyId = entity.CurrencyId;
                });
                _Context.AppointmentDetails.AddRange(details);
                await _Context.SaveChangesAsync();
            }
            return insertResult;
        }

        public override async Task<Result<Appointment>> UpdateAsync(Appointment entity, bool getFromDb = true)
        {
            entity.Active = true;
            var validStates = new char[] { (char)AppointmentStates.Scheduled, (char)AppointmentStates.InProgress };
            if (!validStates.Contains(entity.State))
                return new Result<Appointment>(-1, -1, "appointmentAlreadyProcessed_msg");


            entity.Details = entity.Details == null ? new List<AppointmentDetail>() : entity.Details;

            if (entity.Details.Count == 0)
                return new Result<Appointment>(-1, -1, "emptyAppointment_msg");

            entity.Details.ForEach(d =>
            {
                d.Product = null;
                d.Doctor = null;
                d.Currency = null;
                d.Appointment = null;
                d.Date = entity.Date;
                d.Active = true;
                d.MedicalSpeciality = null;
                d.TotalAmount = d.BeforeTaxesAmount + d.TaxesAmount;
                d.PatientPaymentAmount = d.TotalAmount - d.InsuranceCoverageAmount;
            });

            var doctorConsultations = entity.Details?.Where(x => x.Type == (char)AppointmentTypes.Consultation && x.DoctorId.HasValue).ToList();
            if (doctorConsultations.Count > 1)
                return new Result<Appointment>(-1, -1, "onlyOneConsultationPerAppointment_msg");

            entity.Active = true;
            // entity.State = (char)AppointmentStates.Scheduled;
            entity.BeforeTaxesAmount = entity.Details.Sum(x => x.BeforeTaxesAmount);
            entity.TaxesAmount = entity.Details.Sum(x => x.TaxesAmount);
            entity.InsuranceCoverageAmount = entity.Details.Sum(x => x.InsuranceCoverageAmount);
            entity.TotalAmount = entity.BeforeTaxesAmount + entity.TaxesAmount;
            entity.PatientPaymentAmount = entity.TotalAmount - entity.InsuranceCoverageAmount;
            bool exists = false;

            doctorConsultations.ForEach(d =>
            {

                if (_Context.AppointmentDetails.AsNoTracking().Include(x => x.Appointment).Any(x => x.Active == true && x.DoctorId == d.DoctorId &&
                   x.Appointment.State != (char)AppointmentStates.Nulled && x.Date == entity.Date && x.AppointmentId != d.AppointmentId))
                    exists = true;
            });

            if (exists)
                return new Result<Appointment>(-1, -1, "appointmentExist_msg");

            var details = entity.Details;
            entity.Details = null;
            entity.Patient = null;
            entity.Hospital = null;
            entity.Insurance = null;
            entity.InsurancePlan = null;
            entity.Currency = null;
            var updateResult = await base.UpdateAsync(entity, getFromDb);
            if (updateResult.Status >= 0)
            {
                var oldDetails = _Context.AppointmentDetails.AsNoTracking().Where(x => x.Active == true && x.AppointmentId == entity.Id).ToList();
                _Context.AppointmentDetails.UpdateRange(details.Where(x => x.Id > 0));
             await   _Context.SaveChangesAsync();

                var newDetails = details.Where(x => x.Id == 0).ToList();
                newDetails.ForEach(d =>
                {
                    d.Active = true;
                    d.AppointmentId = entity.Id;
                    d.CurrencyId = entity.CurrencyId;
                    d.Date = entity.Date;
                });
                _Context.AppointmentDetails.AddRange(newDetails);
               await _Context.SaveChangesAsync();

                oldDetails.ForEach(od =>
                {
                    if (!details.Any(x => x.Id == od.Id))
                    {
                        od.Active = false;
                        _Context.AppointmentDetails.Update(od);
                        _Context.SaveChanges();
                    }
                });
            }
            return updateResult;
        }

        public override async Task<Result<Appointment>> RemoveAsync(long id)
        {
            var appointment = (await this.GetAsync(id)).Data.FirstOrDefault();
            if (appointment.State != (char)AppointmentStates.Scheduled)
                return new Result<Appointment>(-1, -1, "AppointmentIsProcess_msg");

            appointment.State = (char)AppointmentStates.Nulled;
            return await base.UpdateAsync(appointment, true);
        }

        public async Task<List<Appointment>> GetAppointmentsByDay(DateTime date, long hospitalId, string doctorId, long? medicalSpeciality, long? patientId, string type = null)
        {

            return await this._Context.AppointmentDetails.AsNoTracking().Include(x => x.MedicalSpeciality)
                .Include(x => x.Appointment).ThenInclude(a => a.Hospital)
                .Include(x => x.Appointment).ThenInclude(a => a.Insurance)
                .Include(x => x.Appointment).ThenInclude(a => a.InsurancePlan)
                  .Include(x => x.Appointment).ThenInclude(a => a.Currency)
                .Include(x => x.Appointment).ThenInclude(a => a.Patient)
                 .Include(x => x.Product)
                 .Include(x => x.Doctor).Include(x => x.Currency)
                 .Where(x => x.Active == true && (hospitalId > 0 ? x.Appointment.HospitalId == hospitalId : x.Appointment.HospitalId > 0) &&
                       (medicalSpeciality.HasValue && medicalSpeciality.Value > 0 ? x.MedicalSpecialityId == medicalSpeciality : x.Id > 0) &&
                       (patientId.HasValue && patientId.Value > 0 ? x.Appointment.PatientId == patientId : x.Appointment.PatientId > 0) &&
                       (!string.IsNullOrEmpty(doctorId) ? x.DoctorId == (new Guid(doctorId)) : x.Id > 0) &&
                       (!string.IsNullOrEmpty(type) && type.Length == 1 ? x.Type == type[0] : x.Id > 0) &&
                       (x.Date.Year == date.Year) && x.Date.Month == date.Month && x.Date.Day == date.Day
                   )
                 .Select(x => new Appointment()
                 {
                     Active = x.Appointment.Active,
                     BeforeTaxesAmount = x.Appointment.BeforeTaxesAmount,
                     InsuranceCoverageAmount = x.Appointment.InsuranceCoverageAmount,
                     PatientPaymentAmount = x.Appointment.PatientPaymentAmount,
                     TaxesAmount = x.Appointment.TaxesAmount,
                     TotalAmount = x.Appointment.TotalAmount,
                     Currency = x.Appointment.Currency,
                     CurrencyId = x.Appointment.CurrencyId,
                     Date = x.Appointment.Date,
                     CurrencyName = x.Appointment.Currency.Name,
                     Hospital = x.Appointment.Hospital,
                     HospitalId = x.Appointment.HospitalId,
                     Insurance = x.Appointment.Insurance,
                     InsuranceId = x.Appointment.InsuranceId,
                     InsuranceName = x.Appointment.Insurance != null ? x.Appointment.Insurance.Name : "",
                     HospitalName = x.Appointment.Hospital.Name,
                     InsurancePlan = x.Appointment.InsurancePlan,
                     Id = x.AppointmentId,
                     InsurancePlanId = x.Appointment.InsurancePlanId,
                     InsurancePlanName = x.Appointment.InsurancePlan != null ? x.Appointment.InsurancePlan.Name : "",
                     Patient = x.Appointment.Patient,
                     PatientId = x.Appointment.PatientId,
                     PatientName = x.Appointment.Patient.NameAndCode,
                     State = x.Appointment.State,
                     DoctorName = x.Doctor != null ? $"{x.Doctor.FullName}" : "",
                     MedicalSpecialityName = x.MedicalSpeciality != null ? x.MedicalSpeciality.Name : "",
                     ProductName = x.Product != null ? x.Product.Name : "",
                     AppointmentType = x.Type.ToString()
                 }).OrderBy(x => x.Date)
                 .ToListAsync();
        }

        public async Task<List<Appointment>> GetAppointmentsByMonth(DateTime date, long hospitalId, string doctorId, long? medicalSpeciality, long? patientId, string type = null)
        {
            if (date >= new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day))
                await UpdateExpiredAppointments();

            return await this._Context.AppointmentDetails.AsNoTracking().Include(x => x.MedicalSpeciality)
                  .Include(x => x.Appointment).ThenInclude(a => a.Hospital)
                .Include(x => x.Appointment).ThenInclude(a => a.Insurance)
                .Include(x => x.Appointment).ThenInclude(a => a.InsurancePlan)
                  .Include(x => x.Appointment).ThenInclude(a => a.Currency)
                .Include(x => x.Appointment).ThenInclude(a => a.Patient)
               .Include(x => x.Product).Include(x => x.Doctor).Include(x => x.Currency).Where(x => x.Active == true && (hospitalId > 0 ? x.Appointment.HospitalId == hospitalId : x.Appointment.HospitalId > 0) &&
                          (medicalSpeciality.HasValue && medicalSpeciality.Value > 0 ? x.MedicalSpecialityId == medicalSpeciality : x.Id > 0) &&
                       (patientId.HasValue && patientId.Value > 0 ? x.Appointment.PatientId == patientId : x.Appointment.PatientId > 0) &&
                       (!string.IsNullOrEmpty(doctorId) ? x.DoctorId == (new Guid(doctorId)) : x.Id > 0) &&
                       (!string.IsNullOrEmpty(type) && type.Length == 1 ? x.Type == type[0] : x.Id > 0) &&
                     ((x.Date.Month == date.Month) && x.Date.Year == date.Year))
                 .Select(x => new Appointment()
                 {
                     Active = x.Appointment.Active,
                     BeforeTaxesAmount = x.Appointment.BeforeTaxesAmount,
                     InsuranceCoverageAmount = x.Appointment.InsuranceCoverageAmount,
                     PatientPaymentAmount = x.Appointment.PatientPaymentAmount,
                     TaxesAmount = x.Appointment.TaxesAmount,
                     TotalAmount = x.Appointment.TotalAmount,
                     Currency = x.Appointment.Currency,
                     CurrencyId = x.Appointment.CurrencyId,
                     Date = x.Appointment.Date,
                     CurrencyName = x.Appointment.Currency.Name,
                     Hospital = x.Appointment.Hospital,
                     HospitalId = x.Appointment.HospitalId,
                     Insurance = x.Appointment.Insurance,
                     InsuranceId = x.Appointment.InsuranceId,
                     InsuranceName = x.Appointment.Insurance != null ? x.Appointment.Insurance.Name : "",
                     HospitalName = x.Appointment.Hospital.Name,
                     InsurancePlan = x.Appointment.InsurancePlan,
                     Id = x.AppointmentId,
                     InsurancePlanId = x.Appointment.InsurancePlanId,
                     InsurancePlanName = x.Appointment.InsurancePlan != null ? x.Appointment.InsurancePlan.Name : "",
                     Patient = x.Appointment.Patient,
                     PatientId = x.Appointment.PatientId,
                     PatientName = x.Appointment.Patient.NameAndCode,
                     State = x.Appointment.State,
                     DoctorName = x.Doctor != null ? $"{x.Doctor.FullName}" : "",
                     MedicalSpecialityName = x.MedicalSpeciality != null ? x.MedicalSpeciality.Name : "",
                     ProductName = x.Product != null ? x.Product.Name : "",
                     AppointmentType = x.Type.ToString()
                 }).OrderBy(x => x.Date)
                 .ToListAsync();
        }

        private async Task UpdateExpiredAppointments()
        {
            DateTime todayStart = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

            var expiredAppointments = await this._Context.Appointments.AsNoTracking().Where(x => x.Active == true && x.State == (char)AppointmentStates.Scheduled && x.Date <= todayStart).ToListAsync();

            for (int i = 0; i < expiredAppointments.Count; i++)
            {
                expiredAppointments[i].State = (char)AppointmentStates.Expired;
            }

            if (expiredAppointments.Count > 0)
            {
                _Context.Appointments.UpdateRange(expiredAppointments);
                await _Context.SaveChangesAsync();
            }
        }
    }
}
