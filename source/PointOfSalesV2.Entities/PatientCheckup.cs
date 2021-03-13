using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using PointOfSalesV2.Common;

namespace PointOfSalesV2.Entities
{
    public class PatientCheckup : CommonData
    {

        public long PatientId { get; set; }
        public Guid DoctorId { get; set; }
        public long? InsuranceId { get; set; }
        public long? InsurancePlanId { get; set; }
        public long AppointmentId { get; set; }
        public string Symptoms { get; set; }
        public string Diagnoses { get; set; }




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


    }
}

