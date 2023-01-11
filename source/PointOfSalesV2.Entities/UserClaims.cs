
using System.Runtime.Serialization;

namespace PointOfSalesV2.Entities
{
    public class UserClaims : CommonData
    {
        public Guid UserId { get; set; }
        [MaxLength(100)]
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }


        [NotMapped]
        [IgnoreDataMember]
        public override string TranslationData { get; set; }

    }
}
