

namespace PointOfSalesV2.Entities
{
    public class AppointmentDetail : CommonData
    {
        public long AppointmentId { get; set; }
        public Guid? DoctorId { get; set; }
        public long? MedicalSpecialityId { get; set; }
        public long ProductId { get; set; }
        public long CurrencyId { get; set; }

        public decimal BeforeTaxesAmount { get; set; }
        public decimal PatientPaymentAmount { get; set; }

        public decimal TaxesAmount { get; set; }
        public decimal InsuranceCoverageAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public char Type { get; set; } = 'C';

       

        [NotMapped]
        public AppointmentTypes AppointmentType
        {
            get
            {
                return (AppointmentTypes)this.Type;
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
       
        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        [ForeignKey("AppointmentId")]
        public Appointment Appointment { get; set; }



        [ForeignKey("DoctorId")]
        public User Doctor { get; set; }

        [ForeignKey("CurrencyId")]
        public Currency Currency { get; set; }

       

        [NotMapped]
        public string MedicalSpecialityName { get; set; }

       

        [NotMapped]
        public string SpecialityName { get; set; }

        [NotMapped]
        public string ProductName { get; set; }


        [NotMapped]
        public string DoctorName { get; set; }


        [NotMapped]
        public string CurrencyName { get; set; }


    }
}
