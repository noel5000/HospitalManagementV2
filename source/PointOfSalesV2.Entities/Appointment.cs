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


        public long HospitalId { get; set; }
        public long PatientId { get; set; }
        public long? InsuranceId { get; set; }
        public long? InsurancePlanId { get; set; }
        public long CurrencyId { get; set; }

        public decimal BeforeTaxesAmount { get; set; }
        public decimal PatientPaymentAmount { get; set; }

        public decimal TaxesAmount { get; set; }
        public decimal InsuranceCoverageAmount { get; set; }
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

        public List<AppointmentDetail> Details { get; set; }

       
        [ForeignKey("InsuranceId")]
        public Insurance Insurance { get; set; }
       
        [ForeignKey("PatientId")]
        public Customer Patient { get; set; }
        [ForeignKey("InsurancePlanId")]
        public InsurancePlan InsurancePlan { get; set; }


        [ForeignKey("CurrencyId")]
        public Currency Currency { get; set; }

        [ForeignKey("HospitalId")]
        public BranchOffice Hospital { get; set; }

     

        [NotMapped]
        public string InsuranceName { get; set; }

       

        [NotMapped]
        public string PatientName { get; set; }

        [NotMapped]
        public string InsurancePlanName { get; set; }

     


        [NotMapped]
        public string CurrencyName { get; set; }


        [NotMapped]
        public string HospitalName { get; set; }

        [NotMapped]
        public string MedicalSpecialityName { get; set; }

        [NotMapped]
        public string DoctorName { get; set; }

        [NotMapped]
        public string ProductName { get; set; }

        [NotMapped]
        public string AppointmentType { get; set; }


    }
}
