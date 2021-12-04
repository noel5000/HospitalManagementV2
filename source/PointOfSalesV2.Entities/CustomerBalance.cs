

namespace PointOfSalesV2.Entities
{
    public class CustomerBalance : CommonData
    {

        public long CustomerId { get; set; }

        public long CurrencyId { get; set; }
        [NotMapped]
        [IgnoreDataMember]
        public override string TranslationData { get; set; }

        public decimal OwedAmount { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }


        [ForeignKey("CurrencyId")]
        public Currency Currency { get; set; }




    }
}
