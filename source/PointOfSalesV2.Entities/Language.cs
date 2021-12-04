

namespace PointOfSalesV2.Entities
{
    public class Language : CommonData
    {
        [MaxLength(100)]
        [Translate]
        public string Name { get; set; }
        [MaxLength(2)]
        [Key]
        public string Code { get; set; }

    }
}
