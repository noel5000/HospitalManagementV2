
namespace PointOfSalesV2.Entities
{
 public   class TaxesReport
    {
        public decimal TotalOutcomeAmount { get; set; }
        public decimal TotalIncomeAmount { get; set; }
        public Currency Currency { get; set; }
        
        public List<InvoiceTax> Taxes { get; set; }
    }
}
