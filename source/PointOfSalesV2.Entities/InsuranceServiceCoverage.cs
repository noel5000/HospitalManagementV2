using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PointOfSalesV2.Entities
{
    public class InsuranceServiceCoverage : CommonData
    {
        
   

      
        public long? InsuranceId { get; set; }
        public long ProductId { get; set; }
        public long? InsurancePlanId { get; set; }
        public long CurrencyId { get; set; }
        public decimal CoverageAmount { get; set; }
        public decimal ConsultationPrice { get; set; }


        [ForeignKey("InsuranceId")]
        public Insurance Insurance { get; set; }

        [ForeignKey("InsurancePlanId")]
        public InsurancePlan InsurancePlan { get; set; }


        [ForeignKey("CurrencyId")]
        public Currency Currency { get; set; }


        [ForeignKey("ProductId")]
        public Product Product { get; set; }

    }
}
