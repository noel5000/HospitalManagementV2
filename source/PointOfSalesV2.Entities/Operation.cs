

namespace PointOfSalesV2.Entities
{
    public class Operation : CommonData
    {
        [MaxLength(100)]
        [Translate]
        public string Name { get; set; }

        public IEnumerable<SectionOperation> Sections { get; set; }

    }
}
