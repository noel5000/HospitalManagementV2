

namespace PointOfSalesV2.Entities
{
    public class Unit : CommonData
    {
        [MaxLength(100)]
        [Translate]
        public string Name { get; set; }
    }
}
