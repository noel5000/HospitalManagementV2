using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PointOfSalesV2.Entities
{
    public class Customer : CommonData
    {

        [MaxLength(20)]
        [Export(Order = 3)]
        public string CardId { get; set; }
        [MaxLength(20)]
        [Export(Order = 4)]
        public string PhoneNumber { get; set; }

        [NotMapped]
        public int Age 
        {
            get 
            {
                return Convert.ToInt32((DateTime.Now - this.BirthDate).TotalDays / 365);
            }
        }
        public DateTime BirthDate { get; set; }

        public long CurrencyId { get; set; }
        public long TRNControlId { get; set; }

        [MaxLength(200)]
        [Export(Order = 5)]
        public string Address { get; set; }
        [MaxLength(50)]
        [Export(Order = 1)]
        public string Code { get; set; }
        [Export(Order = 6)]
        public long InvoiceDueDays { get; set; }

        [Export(Order = 7)]
        public decimal BillingAmountLimit { get; set; }
        [Export(Order = 8)]
        public decimal CreditAmountLimit { get; set; }

        public long? ZoneId { get; set; }
        public long? WarehouseId { get; set; }


        [MaxLength(100)]
        [Export(Order = 0)]
        public string Name { get; set; }

        [NotMapped]
        [Export(Order = 2)]
        public string NameAndCode { get { return $"{Code ?? ""}  {Name}"; } }



        [ForeignKey("CurrencyId")]
        [Export(Order = 9, ChildProperty = "Code")]
        public Currency Currency { get; set; }


        [ForeignKey("ZoneId")]
        [Export(Order = 12, ChildProperty = "Name")]
        public Zone Zone { get; set; }



        //Tax receipt number -> NCF
        [MaxLength(50)]
        [Export(Order = 10)]
        public string TRNType { get; set; }

        public virtual IEnumerable<CustomerBalance> CustomerBalances {get;set;}


        [ForeignKey("TRNControlId")]
        [Export(Order =11, ChildProperty ="Name" )]
        public TRNControl TRNControl { get; set; }
        [MaxLength(4)]
        public string BloodType { get; set; }
        public long? InsuranceId { get; set; }

        public long? InsurancePlanId { get; set; }

        [MaxLength(50)]
        public string InsuranceCardId { get; set; }

        [ForeignKey("InsuranceId")]
        public virtual Insurance Insurance { get; set; }

        [ForeignKey("InsurancePlanId")]
        public virtual InsurancePlan InsurancePlan { get; set; }

        #region Custom doctor properties
        [MaxLength(500)]
        public string Informante { get; set; }
        [MaxLength(5000)]
        public string AHF { get; set; }
        [MaxLength(5000)]
        public string APNP { get; set; }
        [MaxLength(5000)]
        public string AntecedentesPerinatales { get; set; }
        [MaxLength(5000)]
        public string DesarrolloPsicomotor { get; set; }
        
        public string AntecedentesPatologicos { get; set; }
        [MaxLength(5000)]
        public string PadenciaActual { get; set; }
        public string ExploracionFisica { get; set; }
        [MaxLength(5000)]
        public string Espirometria { get; set; }
        [MaxLength(5000)]
        public string Paraclinicos { get; set; }
        [MaxLength(2000)]
        public string Diagnosticos { get; set; }

        [MaxLength(5000)]
        public string PlanTerapeutico { get; set; }
        [MaxLength(1000)]
        public string EstadoDeSalud { get; set; }


        #endregion

    }
}
