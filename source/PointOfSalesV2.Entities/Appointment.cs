using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static PointOfSalesV2.Common.Enums;

namespace PointOfSalesV2.Entities
{
    public class Appointment : CommonData
    {

        public Guid? DoctorId { get; set; }

        public long HospitalId { get; set; }
        public long? MedicalSpecialityId { get; set; }
        public long ProductId { get; set; }
        public long PatientId { get; set; }
        public long? InsuranceId { get; set; }
        public long CurrencyId { get; set; }
        public long? InsurancePlanId { get; set; }

        public decimal BeforeTaxesAmount { get; set; }

        public decimal TaxesAmount { get; set; }
        public decimal InsuranceCoverage { get; set; }
        public decimal TotalAmount { get; set; }
        public char State { get; set; }

        [NotMapped]
        public AppointmentStates AppointmentState 
        {
            get 
            {
                return (AppointmentStates)this.State;
            }
        }
        public DateTime Date { get; set; }
        [NotMapped]
        public string AppointmentHourString
        {
            get
            {
                return Date.ToString("hh:mm tt");
            }
        }


        [ForeignKey("MedicalSpecialityId")]
        public MedicalSpeciality MedicalSpeciality { get; set; }
        [ForeignKey("InsuranceId")]
        public Insurance Insurance { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        [ForeignKey("PatientId")]
        public Customer Patient { get; set; }
        [ForeignKey("InsurancePlanId")]
        public InsurancePlan InsurancePlan { get; set; }

        [ForeignKey("DoctorId")]
        public User Doctor { get; set; }

        [ForeignKey("CurrencyId")]
        public Currency Currency { get; set; }

        [ForeignKey("HospitalId")]
        public BranchOffice Hospital { get; set; }

    }
}
