namespace PointOfSalesV2.Entities
{
    public class Zone : CommonData
    {
        [MaxLength(100)]
        [Translate]
        public string Name { get; set; }
        public string Details { get; set; }



    }
}
