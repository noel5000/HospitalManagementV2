

namespace PointOfSalesV2.Entities
{
    public class Role : CommonData
    {
        [MaxLength(100)]
        [Translate]
        public string Name { get; set; }

        public IEnumerable<RoleSectionOperation> SectionOperations { get; set; }

    }
}
