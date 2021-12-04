

namespace PointOfSalesV2.Entities
{
    public class CreditNote : CommonData
    {


        [MaxLength(50)]
        [Export(Order =1 )]
        public string OriginInvoiceNumber { get; set; }
        [MaxLength(50)]
        [Export(Order = 2)]
        public string AppliedInvoiceNumber { get; set; }
        [MaxLength(50)]
        [Export(Order = 3)]
        public string Sequence { get; set; }
        [Export(Order = 4)]
        public decimal Amount { get; set; }

        public long CurrencyId { get; set; }
        public long CustomerId { get; set; }

        [Export(Order = 6)]
        public bool Applied { get; set; }
        [NotMapped]
        [IgnoreDataMember]
        public override string TranslationData { get; set; }

        [ForeignKey("CurrencyId")]
        [Export(Order = 5, ChildProperty ="Code")]
        public Currency Currency { get; set; }

        [Export(Order = 0)]
        public DateTime Date { get; set; }

       
    }
}
