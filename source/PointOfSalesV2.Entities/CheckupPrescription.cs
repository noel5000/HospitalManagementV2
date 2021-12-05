

namespace PointOfSalesV2.Entities
{


    public class CheckupPrescription: CommonData
    {
        public long? ProductId { get; set; }
        public long? MedicalSpecialityId { get; set; }
        public decimal Quantity { get; set; }
        public decimal MedicinesAmount { get; set; }
        public char Type { get; set; }

        [NotMapped]
        public Enums.AppointmentTypes TypeEnum
        {
            get
            {
                return (Enums.AppointmentTypes)this.Type;
            }
        }
        public long PatientCheckupId { get; set; }
        public string WhenToTake { get; set; }
        public bool EmptyStomach { get; set; }
        [MaxLength(1000)]
        public string AdditionalData { get; set; }

        [MaxLength(1000)]
        public string Results { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        [ForeignKey("MedicalSpecialityId")]
        public MedicalSpeciality MedicalSpeciality { get; set; }
        [ForeignKey("PatientCheckupId")]
        public PatientCheckup PatientCheckup { get; set; }
    }
}
