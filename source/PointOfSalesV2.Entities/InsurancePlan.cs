

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
