using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PointOfSalesV2.Entities
{
    public class InsurancePlan : CommonData
    {
        [MaxLength(100)]
        public string Name { get; set; }

      
        public long InsuranceId { get; set; }

      
        [ForeignKey("InsuranceId")]
        public Insurance Insurance { get; set; }
        public virtual List<Customer> SubscribedPatients { get; set; }

    }
}
