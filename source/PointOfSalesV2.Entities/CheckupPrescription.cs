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


    public class CheckupPrescription: CommonData
    {
        public long ProductId { get; set; }
        public decimal Quantity { get; set; }
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
        public string AdditionalData { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        [ForeignKey("PatientCheckupId")]
        public PatientCheckup PatientCheckup { get; set; }
    }
}
