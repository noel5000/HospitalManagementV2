

namespace PointOfSalesV2.Entities
{
    public class SequenceControl : CommonData
    {
        public short Code { get; set; }
        public long NumericControl { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(10)]
        public string CodeName { get; set; }

    }
}
