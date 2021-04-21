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
    public class PatientCheckupRepository : Repository<PatientCheckup>, IPatientCheckupRepository
    {
        public PatientCheckupRepository(MainDataContext context) : base(context)
        {
        }

        public override Result<PatientCheckup> Get(long id)
        {
            var entity = _Context.PatientCheckups.AsNoTracking().Include(x=>x.Doctor)
                .Include(x=>x.Insurance).Include(x=>x.InsurancePlan).Include(x=>x.Patient).Include(x=>x.CheckupPrescriptions).ThenInclude(x=>x.MedicalSpeciality)
                .Include(x=>x.CheckupPrescriptions).ThenInclude(d=>d.Product).FirstOrDefault(x=>x.Active==true && x.Id==id);
            if (entity == null)
                return new Result<PatientCheckup>(-1, -1, "notFound_msg");
            entity.CheckupPrescriptions = entity.CheckupPrescriptions.Where(s => s.Active == true).ToList();

            return new Result<PatientCheckup>(entity.Id, 0, "ok_msg", new List<PatientCheckup>() { entity });
        }

        public override Result<PatientCheckup> Add(PatientCheckup entity)
        {
            Result<PatientCheckup> result = new Result<PatientCheckup>(-1, -1, "error_msg");
            using (var transaction = _Context.Database.BeginTransaction()) 
            {
                try
                {
                   
                    var prescriptions = SetEntity(entity);
                    var appointment = _Context.Appointments.AsNoTracking().Include(x=>x.Details).FirstOrDefault(x=>x.Id==entity.AppointmentId);
                    appointment.Details = appointment.Details.Where(x => x.Active == true).ToList();
                    var consultationDetail = appointment.Details.FirstOrDefault(x => x.AppointmentType == AppointmentTypes.Consultation);
                    if (appointment == null || appointment.AppointmentState== AppointmentStates.Nulled || consultationDetail==null) 
                    {
                        transaction.Rollback();
                        return new Result<PatientCheckup>(-1, -1, "appointmentNotValid_msg");
                    }
                    entity.Date = appointment.Date;
                    entity.InsuranceId = appointment.InsuranceId;
                    entity.InsurancePlanId = appointment.InsurancePlanId;
                    entity.DoctorId = consultationDetail.DoctorId.HasValue? consultationDetail.DoctorId.Value:entity.DoctorId;
                    entity.PatientId = appointment.PatientId;
                    result = base.Add(entity);
                    if (result.Status < 0) 
                    {
                        
                        transaction.Rollback();
                        return result;
                    }
                  


                    appointment.State = appointment.AppointmentState == AppointmentStates.Scheduled ? (char)AppointmentStates.InProgress : appointment.State;
                    _Context.Appointments.Update(appointment);
                    _Context.SaveChanges();
                    result = SavePrescriptions(prescriptions, result);
                    if (result.Status < 0)
                    {
                        transaction.Rollback();
                        return result;
                    }
                    transaction.Commit();
                    
                }
                catch (Exception ex) 
                {
                    transaction.Rollback();
                    result= new Result<PatientCheckup>(-1, -1, $"error_msg: | {ex.Message}", null, ex);
                }
            }

            return result;

        }

        public override Result<PatientCheckup> Update(PatientCheckup entity, bool getFromDb = true)
        {
            Result<PatientCheckup> result = new Result<PatientCheckup>(-1, -1, "error_msg");
            using (var transaction = _Context.Database.BeginTransaction())
            {
                try
                {

                    var prescriptions = SetEntity(entity);
                    var appointment = _Context.Appointments.Find(entity.AppointmentId);
                    _Context.Entry<Appointment>(appointment).State = EntityState.Detached;
                    result = base.Update(entity);
                    if (result.Status < 0)
                    {
                        transaction.Rollback();
                        return result;
                    }
                    if (appointment.AppointmentState == AppointmentStates.Nulled)
                    {
                        transaction.Dispose();
                        result = new Result<PatientCheckup>(-1, -1, "appointmentNulled_msg");
                        return result;
                    }


                    appointment.State = appointment.AppointmentState == AppointmentStates.Scheduled ? (char)AppointmentStates.InProgress : appointment.State;
                    _Context.Appointments.Update(appointment);
                    _Context.SaveChanges();
                    result = UpdatePrescriptions(prescriptions, result);
                    if (result.Status < 0)
                    {
                        transaction.Rollback();
                        return result;
                    }
                    transaction.Commit();

                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    result = new Result<PatientCheckup>(-1, -1, $"error_msg: | {ex.Message}", null, ex);
                }
            }

            return result;
        }

        private Result<PatientCheckup> SavePrescriptions(List<CheckupPrescription> prescriptions, Result<PatientCheckup> result) 
        {
            try
            {
                if (result.Status < 0)
                    return result;

                for (int i = 0; i < prescriptions.Count; i++)
                {
                    prescriptions[i].PatientCheckupId = result.Id;
                    
                }
                _Context.CheckupPrescriptions.AddRange(prescriptions);
                _Context.SaveChanges();
            }
            catch (Exception ex) 
            {
                result= new Result<PatientCheckup>(-1, -1, $"error_msg | {ex.Message}", null, ex);
            }
            return result;

        }
        private Result<PatientCheckup> UpdatePrescriptions(List<CheckupPrescription> prescriptions, Result<PatientCheckup> result)
        {
            try
            {
                if (result.Status < 0)
                    return result;
                var oldPrescriptions = _Context.CheckupPrescriptions.AsNoTracking().Where(x => x.Active == true && x.PatientCheckupId == result.Id).ToList();

                for (int i = 0; i < oldPrescriptions.Count; i++)
                {
                    oldPrescriptions[i].PatientCheckupId = result.Id;
                    oldPrescriptions[i].Active = false;

                }

                _Context.CheckupPrescriptions.RemoveRange(oldPrescriptions);
                _Context.SaveChanges();

                for (int i = 0; i < prescriptions.Count; i++)
                {
                    prescriptions[i].PatientCheckupId = result.Id;
                    prescriptions[i].Id = 0;
                    prescriptions[i].Active = true;
                }
                _Context.CheckupPrescriptions.AddRange(prescriptions);
                _Context.SaveChanges();
            }
            catch (Exception ex)
            {
                result = new Result<PatientCheckup>(-1, -1, $"error_msg | {ex.Message}", null, ex);
            }
            return result;

        }

        private List<CheckupPrescription> SetEntity(PatientCheckup entity) 
        {
            
            entity.Appointment = null;
            entity.Doctor = null;
            entity.Insurance = null;
            entity.InsurancePlan = null;
            entity.Patient = null;
            var prescriptions = entity.CheckupPrescriptions?? new List<CheckupPrescription>();
            entity.CheckupPrescriptions = null;
            entity.Active = true;
            for (int i = 0; i < prescriptions.Count; i++)
            {
                prescriptions[i].Product = null;
                prescriptions[i].MedicalSpeciality = null;
                prescriptions[i].Active = true;
                prescriptions[i].PatientCheckup = null;
                prescriptions[i].Quantity = prescriptions[i].Quantity <= 0 ? 1 : prescriptions[i].Quantity;
            }
            return prescriptions;
        }

        public async Task<List<PatientCheckup>> GetPatientHistory(long patientId)
        {
            var entities = await _Context.PatientCheckups.AsNoTracking().Include(x => x.Doctor)
                .Include(x=>x.Appointment)
                .Include(x => x.Insurance).Include(x => x.InsurancePlan).Include(x => x.Patient).Where(x => x.Active == true && x.PatientId == patientId).ToListAsync();
            return entities;
        }
    }
}
