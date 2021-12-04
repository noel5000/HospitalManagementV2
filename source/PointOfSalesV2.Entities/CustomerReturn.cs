

namespace PointOfSalesV2.Entities
{
    public class CustomerReturn : CommonData
    {
        [ForeignKey("InvoiceId")]
        public Invoice Invoice { get; set; }
        [MaxLength(50)]
        public string InvoiceNumber { get; set; }

        public long CustomerId { get; set; }

        public long BranchOfficeId { get; set; }
        public long InvoiceId { get; set; }
        public decimal BeforeTaxesAmount { get; set; }

        public decimal TaxesAmount { get; set; }

        public decimal TotalAmount { get; set; }
        [MaxLength(50)]
        public string CreditNoteNumber { get; set; }

        public DateTime Date { get; set; }

        public long CreditNoteId { get; set; }
        public long CurrencyId { get; set; }

        [ForeignKey("CreditNoteId")]
        public CreditNote CreditNote { get; set; }
        [ForeignKey("BranchOfficeId")]
        public BranchOffice BranchOffice { get; set; }

        [ForeignKey("CurrencyId")]
        public Currency Currency { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }

        public List<CustomerReturnDetail> ReturnDetails { get; set; }
        [NotMapped]
        [IgnoreDataMember]
        public override string TranslationData { get; set; }






    }
}
