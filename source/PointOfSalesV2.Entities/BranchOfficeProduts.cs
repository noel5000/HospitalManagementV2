

namespace PointOfSalesV2.Entities
{ 
    public class BranchOfficeProduts

    {


        public long LocationId { get; set; }
        [ForeignKey("LocationId")]
        public BranchOffice Location { get; set; }
        public List<Inventory> ProductsByWarehouse { get; set; }

    }
}
