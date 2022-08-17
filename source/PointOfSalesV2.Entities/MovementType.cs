
namespace PointOfSalesV2.Entities
{
    public class MovementType : CommonData
    {


        public short Code { get; set; }

        [MaxLength(100)]
        [Translate]
        public string Name { get; set; }

       


    }
}
