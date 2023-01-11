
using System.Runtime.Serialization;

namespace PointOfSalesV2.Entities
{
    public class SupplierBalance : CommonData
    {

        public long SupplierId { get; set; }

        public long CurrencyId { get; set; }

        public decimal OwedAmount { get; set; }
        [NotMapped]
        [IgnoreDataMember]
        public override string TranslationData { get; set; }

        [ForeignKey("SupplierId")]
        public Supplier Supplier { get; set; }


        [ForeignKey("CurrencyId")]
        public Currency Currency { get; set; }




    }
}
