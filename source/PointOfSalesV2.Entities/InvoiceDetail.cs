using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Diagnostics.CodeAnalysis;
using NPOI.OpenXmlFormats.Dml.Diagram;

namespace PointOfSalesV2.Entities
{
    public class InvoiceDetail : CommonData, IDetailEntity, IEquatable<InvoiceDetail>, IEqualityComparer<InvoiceDetail>
    {
        public InvoiceDetail() { }

        public InvoiceDetail(InvoiceDetail newDetail)
        {
            this.Id = newDetail.Id;
            this.ProductId = newDetail.ProductId;
            this.Product = newDetail.Product ?? null;
            this.Active = newDetail.Active;
            this.WarehouseId = newDetail.WarehouseId ?? null;
            this.Quantity = newDetail.Quantity;
            this.Comments = newDetail.Comments;
            this.CreatedBy = newDetail.CreatedBy;
            this.InvoiceId = newDetail.InvoiceId;
            this.Date = newDetail.Date;
            this.CreatedDate = newDetail.CreatedDate;
            this.ModifiedDate = newDetail.ModifiedDate;
            this.ModifiedBy = newDetail.ModifiedBy;
            this.Amount = newDetail.Amount;
            this.PrincipalCurrencyAmount = newDetail.PrincipalCurrencyAmount;
            this.BeforeTaxesAmount = newDetail.BeforeTaxesAmount;
            this.TaxesAmount = newDetail.TaxesAmount;
            this.TotalAmount = newDetail.TotalAmount;
            this.Unit = newDetail.Unit ?? null;
            this.UnitId = newDetail.UnitId ?? null;
            this.DiscountAmount = newDetail.DiscountAmount;
            this.CreditNoteAmount = newDetail.CreditNoteAmount;
            this.ParentId = newDetail.ParentId;
            this.SaveRegister = newDetail.SaveRegister;
            this.DiscountRate = newDetail.DiscountRate;
            this.Free = newDetail.Free;
            this.SellerRate = newDetail.SellerRate;
            this.Cost = newDetail.Cost;
            this.ReturnAmount = newDetail.ReturnAmount;
            this.Defective = newDetail.Defective;
            this.BranchOfficeId = newDetail.BranchOfficeId;

            this.MedicalSpecialityId = newDetail.MedicalSpecialityId;
            this.Type = newDetail.Type;
            this.InsuranceCoverageAmount = newDetail.InsuranceCoverageAmount;
            this.DoctorId = newDetail.DoctorId;
            this.InsuranceApprovalCode = newDetail.InsuranceApprovalCode;
            this.PatientPaymentAmount = newDetail.PatientPaymentAmount;
            this.NoCoverage = newDetail.NoCoverage;
            this.MedicalSpeciality = newDetail.MedicalSpeciality;
            this.Doctor = newDetail.Doctor;
        }
        [NotMapped]
        public bool Defective { get; set; }
        [NotMapped]
        public decimal ReturnAmount { get; set; }

        public long BranchOfficeId { get; set; }
        public string InsuranceApprovalCode { get; set; }

        public Guid? DoctorId { get; set; }
        public char Type { get; set; }
        public long? AppointmentId { get; set; }
        public long? MedicalSpecialityId { get; set; }

        public decimal InsuranceCoverageAmount { get; set; }
        public decimal PatientPaymentAmount { get; set; }
        public bool NoCoverage { get; set; }

        public long ProductId { get; set; }
        [Export(Order = 2)]
        public decimal Quantity { get; set; }
        [Export(Order = 18)]
        public decimal SellerRate { get; set; } = 0;
        [Export(Order = 7)]
        public decimal Cost { get; set; }
        [NotMapped]
        [IgnoreDataMember]
        public override string TranslationData { get; set; }
        [Export(Order = 4)]
        public decimal Amount { get; set; }
        [Export(Order = 5)]
        public decimal TaxesAmount { get; set; }
        [Export(Order = 7)]
        public decimal TotalAmount { get; set; }
        public bool Free { get; set; }
        [Export(Order = 3)]
        public DateTime Date { get; set; }

        public long InvoiceId { get; set; }

        [Export(Order = 6)]
        public decimal BeforeTaxesAmount { get; set; }
        [MaxLength(200)]
        [Export(Order = 12)]
        public string Comments { get; set; }

        [Export(Order = 8)]
        public decimal PrincipalCurrencyAmount { get; set; }
        [Export(Order = 9)]
        public decimal DiscountRate { get; set; }

        public Nullable<long> WarehouseId { get; set; }



        [Export(Order = 10)]
        public decimal DiscountAmount { get; set; }
        [Export(Order = 11)]
        public decimal CreditNoteAmount { get; set; }

        public Nullable<long> ParentId { get; set; }

        public Nullable<long> UnitId { get; set; }

        public bool Equals(InvoiceDetail other)
        {
            return (this.Id == other.Id && this.ProductId == other.ProductId && this.Quantity == other.Quantity && this.Amount == other.Amount && this.Cost == other.Cost &&
                this.UnitId == other.UnitId && this.TaxesAmount == other.TaxesAmount && this.BeforeTaxesAmount == other.BeforeTaxesAmount && this.TotalAmount == other.TotalAmount &&
                this.InvoiceId == other.InvoiceId && this.CreditNoteAmount == other.CreditNoteAmount && this.DiscountAmount == other.DiscountAmount && this.DiscountRate == other.DiscountRate
                && this.Free == other.Free && this.ParentId == other.ParentId && this.WarehouseId == other.WarehouseId &&

                this.MedicalSpecialityId == other.MedicalSpecialityId && this.Type == other.Type && this.InsuranceCoverageAmount == other.InsuranceCoverageAmount &&
            this.DoctorId == other.DoctorId && this.InsuranceApprovalCode == other.InsuranceApprovalCode && this.PatientPaymentAmount == other.PatientPaymentAmount &&
            this.NoCoverage == other.NoCoverage &&

            this.Active == other.Active && this.Date == other.Date && this.CreatedDate == other.CreatedDate);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                long hashCode = 13;
                hashCode = (hashCode * 397) ^ Convert.ToInt32(this.Id);

                hashCode = (hashCode * 397) ^ Convert.ToInt32(this.ProductId);
                hashCode = (hashCode * 397) ^ Convert.ToInt32(this.InvoiceId);



                hashCode = this.UnitId.HasValue ? (hashCode * 397) ^ this.UnitId.Value : hashCode;
                hashCode = this.ParentId.HasValue ? (hashCode * 397) ^ this.ParentId.Value : hashCode;
                hashCode = this.WarehouseId.HasValue ? (hashCode * 397) ^ this.WarehouseId.Value : hashCode;
                hashCode = (hashCode * 397) ^ Convert.ToInt32(this.Active);

                var hashCodeDecimal = this.Quantity.GetHashCode();
                hashCode = hashCode ^ hashCodeDecimal;

                var hashCodeDecimal2 = this.Amount.GetHashCode();
                hashCode = hashCode ^ hashCodeDecimal2;

                var hashCodeDecimal3 = this.BeforeTaxesAmount.GetHashCode();
                hashCode = hashCode ^ hashCodeDecimal3;

                var hashCodeDecimal4 = this.TaxesAmount.GetHashCode();
                hashCode = hashCode ^ hashCodeDecimal4;

                var hashCodeDecimal5 = this.TotalAmount.GetHashCode();
                hashCode = hashCode ^ hashCodeDecimal5;

                var hashCodeDecimal6 = this.DiscountAmount.GetHashCode();
                hashCode = hashCode ^ hashCodeDecimal6;

                var hashCodeDecimal7 = this.CreditNoteAmount.GetHashCode();
                hashCode = hashCode ^ hashCodeDecimal7;

                var hashCodeDecimal8 = this.DiscountRate.GetHashCode();
                hashCode = hashCode ^ hashCodeDecimal8;

                var hashCodeDecimal9 = this.Cost.GetHashCode();
                hashCode = hashCode ^ hashCodeDecimal9;

                var hashCodeDecima20 = this.InsuranceCoverageAmount.GetHashCode();
                hashCode = hashCode ^ hashCodeDecima20;

                var hashCodeDecima21 = this.PatientPaymentAmount.GetHashCode();
                hashCode = hashCode ^ hashCodeDecima21;


                return Convert.ToInt32(hashCode);
            }
        }

        public bool Equals([AllowNull] InvoiceDetail x, [AllowNull] InvoiceDetail y)
        {
            return x.Id == y.Id && x.ProductId == y.ProductId && x.UnitId == y.UnitId && x.Quantity == y.Quantity && x.InvoiceId == y.InvoiceId && x.DoctorId == y.DoctorId && x.MedicalSpecialityId == y.MedicalSpecialityId && y.Type == x.Type;
        }

        public int GetHashCode([DisallowNull] InvoiceDetail obj)
        {
            return GetHashCode(obj);
        }

        [ForeignKey("ProductId")]
        [Export(Order = 1, ChildProperty = "Name")]
        public Product Product { get; set; }



        [ForeignKey("UnitId")]
        [Export(Order = 13, ChildProperty = "Name")]
        public Unit Unit { get; set; }

        [ForeignKey("DoctorId")]
        [Export(Order = 13, ChildProperty = "FullName")]
        public User Doctor { get; set; }

        [ForeignKey("MedicalSpecialityId")]
        [Export(Order = 13, ChildProperty = "Name")]
        public MedicalSpeciality MedicalSpeciality { get; set; }


        [ForeignKey("InvoiceId")]
        [Export(Order = 0, ChildProperty = "DocumentNumber")]
        public Invoice Invoice { get; set; }

        [NotMapped]
        public bool SaveRegister { get; set; } = true;
        [NotMapped]
        public Insurance Insurance { get; set; }


        [NotMapped]
        public InsurancePlan InsurancePlan { get; set; }

        [NotMapped]
        public char InvoiceState { get; set; }
        [NotMapped]
        public string InsuranceCardId { get; set; }
        [NotMapped]
        public string InvoiceNumber { get; set; }
        [NotMapped]
        public string PatientName { get; set; }
        [NotMapped]
        public string PatientCardId { get; set; }
        [NotMapped]
        public Currency Currency { get; set; }
        [NotMapped]
        public int DaysAmount { get { return Convert.ToInt32((DateTime.Now - this.Date).TotalDays); } }




    }

    public class InsurancCoverageDetail : CommonData
    {
        public InsurancCoverageDetail() { }

        public InsurancCoverageDetail(InvoiceDetail newDetail)
        {
            this.Id = newDetail.Id;
            this.ProductId = newDetail.ProductId;
            this.Product = newDetail.Product ?? null;
            this.Active = newDetail.Active;
            this.WarehouseId = newDetail.WarehouseId ?? null;
            this.Comments = newDetail.Comments;
            this.CreatedBy = newDetail.CreatedBy;
            this.InvoiceId = newDetail.InvoiceId;
            this.Date = newDetail.Date;
            this.CreatedDate = newDetail.CreatedDate;
            this.ModifiedDate = newDetail.ModifiedDate;
            this.ModifiedBy = newDetail.ModifiedBy;
            this.Amount = newDetail.Amount;
            this.PrincipalCurrencyAmount = newDetail.PrincipalCurrencyAmount;
            this.BeforeTaxesAmount = newDetail.BeforeTaxesAmount;
            this.TaxesAmount = newDetail.TaxesAmount;
            this.TotalAmount = newDetail.TotalAmount;
            this.Unit = newDetail.Unit ?? null;
            this.UnitId = newDetail.UnitId ?? null;
            this.DiscountAmount = newDetail.DiscountAmount;
            this.CreditNoteAmount = newDetail.CreditNoteAmount;
            this.ParentId = newDetail.ParentId;
            this.SaveRegister = newDetail.SaveRegister;
            this.DiscountRate = newDetail.DiscountRate;
           
            this.Cost = newDetail.Cost;
            this.BranchOfficeId = newDetail.BranchOfficeId;

            this.MedicalSpecialityId = newDetail.MedicalSpecialityId;
            this.Type = newDetail.Type;
            this.InsuranceCoverageAmount = newDetail.InsuranceCoverageAmount;
            this.DoctorId = newDetail.DoctorId;
            this.InsuranceApprovalCode = newDetail.InsuranceApprovalCode;
            this.PatientPaymentAmount = newDetail.PatientPaymentAmount;
            this.MedicalSpeciality = newDetail.MedicalSpeciality;
            this.Doctor = newDetail.Doctor;
        }
       
      
        public long BranchOfficeId { get; set; }
        [Export(Order = 12)]
        public string InsuranceApprovalCode { get; set; }

        public Guid? DoctorId { get; set; }
        public char Type { get; set; }
        public long? AppointmentId { get; set; }
        public long? MedicalSpecialityId { get; set; }
        [Export(Order = 10)]
        public decimal InsuranceCoverageAmount { get; set; }
        [Export(Order = 11)]
        public decimal PatientPaymentAmount { get; set; }

        public long ProductId { get; set; }
       
        public decimal Cost { get; set; }
        public decimal Amount { get; set; }
        public decimal TaxesAmount { get; set; }
        [Export(Order = 9)]
        public decimal TotalAmount { get; set; }
        [Export(Order = 3)]
        public DateTime Date { get; set; }

        public long InvoiceId { get; set; }

        public decimal BeforeTaxesAmount { get; set; }
        [MaxLength(200)]
      
        public string Comments { get; set; }

    
        public decimal PrincipalCurrencyAmount { get; set; }
      
        public decimal DiscountRate { get; set; }

        public Nullable<long> WarehouseId { get; set; }



        public decimal DiscountAmount { get; set; }
    
        public decimal CreditNoteAmount { get; set; }

        public Nullable<long> ParentId { get; set; }

        public Nullable<long> UnitId { get; set; }

      

        public override int GetHashCode()
        {
            unchecked
            {
                long hashCode = 13;
                hashCode = (hashCode * 397) ^ Convert.ToInt32(this.Id);

                hashCode = (hashCode * 397) ^ Convert.ToInt32(this.ProductId);
                hashCode = (hashCode * 397) ^ Convert.ToInt32(this.InvoiceId);



                hashCode = this.UnitId.HasValue ? (hashCode * 397) ^ this.UnitId.Value : hashCode;
                hashCode = this.ParentId.HasValue ? (hashCode * 397) ^ this.ParentId.Value : hashCode;
                hashCode = this.WarehouseId.HasValue ? (hashCode * 397) ^ this.WarehouseId.Value : hashCode;
                hashCode = (hashCode * 397) ^ Convert.ToInt32(this.Active);

                var hashCodeDecimal = (1).GetHashCode();
                hashCode = hashCode ^ hashCodeDecimal;

                var hashCodeDecimal2 = this.Amount.GetHashCode();
                hashCode = hashCode ^ hashCodeDecimal2;

                var hashCodeDecimal3 = this.BeforeTaxesAmount.GetHashCode();
                hashCode = hashCode ^ hashCodeDecimal3;

                var hashCodeDecimal4 = this.TaxesAmount.GetHashCode();
                hashCode = hashCode ^ hashCodeDecimal4;

                var hashCodeDecimal5 = this.TotalAmount.GetHashCode();
                hashCode = hashCode ^ hashCodeDecimal5;

                var hashCodeDecimal6 = this.DiscountAmount.GetHashCode();
                hashCode = hashCode ^ hashCodeDecimal6;

                var hashCodeDecimal7 = this.CreditNoteAmount.GetHashCode();
                hashCode = hashCode ^ hashCodeDecimal7;

                var hashCodeDecimal8 = this.DiscountRate.GetHashCode();
                hashCode = hashCode ^ hashCodeDecimal8;

                var hashCodeDecimal9 = this.Cost.GetHashCode();
                hashCode = hashCode ^ hashCodeDecimal9;

                var hashCodeDecima20 = this.InsuranceCoverageAmount.GetHashCode();
                hashCode = hashCode ^ hashCodeDecima20;

                var hashCodeDecima21 = this.PatientPaymentAmount.GetHashCode();
                hashCode = hashCode ^ hashCodeDecima21;


                return Convert.ToInt32(hashCode);
            }
        }

     

        public int GetHashCode([DisallowNull] InvoiceDetail obj)
        {
            return GetHashCode(obj);
        }

        [ForeignKey("ProductId")]
        [Export(Order = 7, ChildProperty = "Name")]
        public Product Product { get; set; }



        [ForeignKey("UnitId")]
        public Unit Unit { get; set; }

        [ForeignKey("DoctorId")]
        [Export(Order = 0, ChildProperty = "FullName")]
        public User Doctor { get; set; }

        [ForeignKey("MedicalSpecialityId")]
        public MedicalSpeciality MedicalSpeciality { get; set; }


        [ForeignKey("InvoiceId")]
        public Invoice Invoice { get; set; }

        [NotMapped]
        public bool SaveRegister { get; set; } = true;
        [NotMapped]
        [Export(Order = 0, ChildProperty = "Name")]
        public Insurance Insurance { get; set; }


        [NotMapped]
        [Export(Order = 1, ChildProperty = "Name")]
        public InsurancePlan InsurancePlan { get; set; }

        [NotMapped]
        public char InvoiceState { get; set; }
        [NotMapped]
        [Export(Order = 5)]
        public string InsuranceCardId { get; set; }
        [NotMapped]
        [Export(Order = 6)]
        public string InvoiceNumber { get; set; }
        [NotMapped]
        [Export(Order = 3)]
        public string PatientName { get; set; }
        [NotMapped]
        [Export(Order = 4)]
        public string PatientCardId { get; set; }
        [NotMapped]
        [Export(Order = 8, ChildProperty ="Code")]
        public Currency Currency { get; set; }
        [NotMapped]
        public int DaysAmount { get { return Convert.ToInt32((DateTime.Now - this.Date).TotalDays); } }




    }

}

