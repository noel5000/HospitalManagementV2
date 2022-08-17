

namespace PointOfSalesV2.Entities
{
    public class Tax : CommonData
    {
        public decimal Rate { get; set; }
        [MaxLength(100)]
        [Translate]
        public string Name { get; set; }



    }
}
