
using System.Runtime.Serialization;

namespace PointOfSalesV2.Entities
{
    public class UserRole : CommonData
    {
        public Guid UserId { get; set; }
        public long RoleId { get; set; }

        [NotMapped]
        [IgnoreDataMember]
        public override string TranslationData { get; set; }
        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }



    }
}
