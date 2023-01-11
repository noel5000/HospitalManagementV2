
using System.Runtime.Serialization;

namespace PointOfSalesV2.Entities
{
    public class RoleSectionOperation : CommonData
    {
        public long RoleId { get; set; }
        [NotMapped]
        [IgnoreDataMember]
        public override string TranslationData { get; set; }
       public long SectionOperationId { get; set; }
        [ForeignKey("SectionOperationId")]
      public virtual SectionOperation SectionOperation { get; set; }
        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }
        [NotMapped]
        public Section Section { get; set; }
        [NotMapped]
        public Operation Operation { get; set; }

    }
}
