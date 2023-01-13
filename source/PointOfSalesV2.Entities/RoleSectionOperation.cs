
using System.Runtime.Serialization;

namespace PointOfSalesV2.Entities
{
    public class RoleSectionOperation : CommonData
    {
        public long RoleId { get; set; }
        [NotMapped]
        [IgnoreDataMember]
        public override string TranslationData { get; set; }
       public long OperationId { get; set; }
        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }
        [ForeignKey("OperationId")]
        public Operation Operation { get; set; }
        public string Section { get; set; }

    }
}
