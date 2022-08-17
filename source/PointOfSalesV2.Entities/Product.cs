
global using static PointOfSalesV2.Common.Enums;

namespace PointOfSalesV2.Entities
{
    public class Product : CommonData
    {

        [MaxLength(200)]
        [Translate]
        [Export(Order = 1)]
        public string Description { get; set; }
        [Export(Order = 6)]
        public decimal Price { get; set; }
        [Export(Order = 7)]
        public decimal Price2 { get; set; }
        [Export(Order = 8)]
        public decimal Price3 { get; set; }
        [MaxLength(50)]
        [Export(Order = 3)]
        public string Code { get; set; }
        [NotMapped]
        public long OldId { get; set; }
        public char Type { get; set; } = 'C';

        [NotMapped]
        public AppointmentTypes ProductType 
        {
            get 
            {
                return (AppointmentTypes)this.Type;
            }
        }

        public long? MedicalSpecialityId { get; set; }
        public string DetailsClass { get; set; }
        public bool IsService { get; set; }
        public bool IsCompositeProduct { get; set; }
        [Export(Order = 5)]
        public decimal Cost { get; set; }
        [Export(Order = 9)]
        public decimal SellerRate { get; set; } = 0;
        
        public long CurrencyId { get; set; }
        public decimal Existence { get; set; }
        [MaxLength(100)]
        [Translate]
        [Export(Order = 0)]
        public string Name { get; set; }

        [MaxLength(50)]
        [Export(Order = 2)]
        public string Sequence { get; set; }

        public string Details { get; set; }





        [ForeignKey("CurrencyId")]
        [Export(Order = 4, ChildProperty = "Code")]
        public Currency Currency { get; set; }


        [ForeignKey("MedicalSpecialityId")]
        [Export(Order = 4, ChildProperty = "Name")]
        public MedicalSpeciality MedicalSpeciality { get; set; }




        public IEnumerable<ProductTax> Taxes { get; set; }






        public IEnumerable<UnitProductEquivalence> ProductUnits { get; set; }
        public IEnumerable<ProductSupplierCost> SuppliersCosts { get; set; }


        public IEnumerable<CompositeProduct> BaseCompositeProducts { get; set; }



    }
}
