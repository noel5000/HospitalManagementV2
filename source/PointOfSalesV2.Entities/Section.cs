

namespace PointOfSalesV2.Entities
{
    public class Section : CommonData
    {
        [MaxLength(100)]
        [Translate]
        public string Name { get; set; }
        [MaxLength(1000)]
        public string Controllers { get; set; } = "";

        public virtual ICollection<SectionOperation> Operations { get; set; }

    }
}
