using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PointOfSalesV2.Entities
{
    public class Insurance : CommonData
    {
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(50)]
        [Export(Order = 3)]
        public string AccountNumber { get; set; }
        [MaxLength(20)]
        [Export(Order = 4)]
        public string PhoneNumber { get; set; }

        public long CurrencyId { get; set; }

        [MaxLength(200)]
        [Export(Order = 5)]
        public string Address { get; set; }
        [MaxLength(50)]
        [Export(Order = 1)]
        public string Code { get; set; }


        [MaxLength(50)]
        [Export(Order = 16)]
        public string Contact1 { get; set; }

        [MaxLength(50)]
        [Export(Order = 17)]
        public string Contact2 { get; set; }

        [MaxLength(50)]
        [Export(Order = 18)]
        public string Contact3 { get; set; }


        [NotMapped]
        [Export(Order = 2)]
        public string NameAndCode { get { return $"{Code ?? ""}  {Name}"; } }



        [ForeignKey("CurrencyId")]
        [Export(Order = 9, ChildProperty = "Code")]
        public Currency Currency { get; set; }

        public virtual List<InsurancePlan> InsurancePlans { get; set; }

        public virtual List<Customer> Affiliates { get; set; }
    }
}
