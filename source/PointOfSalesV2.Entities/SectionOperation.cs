
using System.Runtime.Serialization;

namespace PointOfSalesV2.Entities
{
    public class SectionOperation : CommonData
    {
        public long? SectionId { get; set; }
        public long OperationId { get; set; }

        [ForeignKey("SectionId")]
        public virtual Section Section { get; set; }
        [ForeignKey("OperationId")]
        public virtual Operation Operation { get; set; }
        [NotMapped]
        [IgnoreDataMember]
        public override string TranslationData { get; set; }

    }
}
