global using System;
global using System.Collections.Generic;
global using System.ComponentModel.DataAnnotations.Schema;
global using System.ComponentModel.DataAnnotations;
global using PointOfSalesV2.Common;

namespace PointOfSalesV2.Entities
{
    public class PatientCheckup : CommonData
    {

        public long PatientId { get; set; }
        public Guid DoctorId { get; set; }
        public long? InsuranceId { get; set; }
        public long? InsurancePlanId { get; set; }
        public long? AppointmentId { get; set; }
        [MaxLength(2000)]
        public string Symptoms { get; set; }
        [MaxLength(2000)]
        public string Diagnoses { get; set; }
        [MaxLength(2000)]
        public string Plan { get; set; }

        [MaxLength(2000)]
        public string MedicalBackground { get; set; }
        [MaxLength(2000)]
        public string ConsultationReason { get; set; }

        [MaxLength(2000)]
        public string LaboratoriesResults { get; set; }

        [MaxLength(2000)]
        public string ImagesResults { get; set; }

        [MaxLength(500)]
        public string PhysicalExamHeadNeck { get; set; }
        [MaxLength(500)]
        public string PhysicalExam { get; set; }
        [MaxLength(500)]
        public string PhysicalExamChest { get; set; }
        [MaxLength(500)]
        public string PhysicalExamHeart { get; set; }
        [MaxLength(500)]
        public string PhysicalExamLungs { get; set; }
        [MaxLength(500)]
        public string PhysicalExamStomach { get; set; }
        [MaxLength(500)]
        public string PhysicalExamExtremities { get; set; }

        public DateTime Date { get; set; }

        [NotMapped]
        public string DateFormatted
        {
            get
            {
                return Date.ToString("yyyy-MM-dd hh:mm tt");
            }
        }

        [NotMapped]
        public string DayFormatted
        {
            get
            {
                return Date.ToString("yyyy-MM-dd");
            }
        }


        [ForeignKey("PatientId")]
        public Customer Patient { get; set; }

        [ForeignKey("DoctorId")]
        public User Doctor { get; set; }

        [ForeignKey("InsuranceId")]
        public Insurance Insurance { get; set; }

        [ForeignKey("InsurancePlanId")]
        public InsurancePlan InsurancePlan { get; set; }

        [ForeignKey("AppointmentId")]
        public Appointment Appointment { get; set; }

        public virtual List<CheckupPrescription> CheckupPrescriptions { get; set; }

        public virtual List<CheckupAttachment> Attachments { get; set; }


    }
}

