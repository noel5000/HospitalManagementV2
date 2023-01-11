
using System.Runtime.Serialization;

namespace PointOfSalesV2.Entities
{
    public class OpeningAmount : CommonData
    {

        public decimal Amount { get; set; }
        public long Order { get; set; }
        [NotMapped]
        [IgnoreDataMember]
        public override string TranslationData { get; set; }

    }
}
