using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text; using System.Threading.Tasks;
using System.Linq;
using PointOfSalesV2.Common;
using PointOfSalesV2.Repository.Helpers;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using static PointOfSalesV2.Common.Enums;
using System.Threading.Tasks;
using NPOI.SS.Formula.Functions;
using Microsoft.EntityFrameworkCore.Storage;

namespace PointOfSalesV2.Repository
{
    public class InvoiceRepository : Repository<Invoice>, IInvoiceRepository
    {
        private readonly IDataRepositoryFactory dataRepositoryFactory;
        readonly ISequenceManagerRepository sequenceManagerRepository;

        public InvoiceRepository(MainDataContext context, IDataRepositoryFactory newDataRepo) : base(context)
        {
            dataRepositoryFactory = newDataRepo;
            this.sequenceManagerRepository = dataRepositoryFactory.GetCustomDataRepositories<ISequenceManagerRepository>();
        }

        //public override async Task<IQueryable<TResult>> GetAllAsync<TResult>(Func<IQueryable<Invoice>, IQueryable<TResult>> transform, Expression<Func<Invoice, bool>> filter = null, string sortExpression = null)
        //{
        //    var _DbSet = _Context.Set<Invoice>();
        //    var query = filter == null ? _DbSet.AsNoTracking().OrderBy(sortExpression) : _DbSet.AsNoTracking().Where(filter).OrderBy(sortExpression);

        //    var notSortedResults = transform(query);

        //    var sortedResults = sortExpression == null ? notSortedResults : notSortedResults.OrderBy(sortExpression);

        //    return sortedResults.AsQueryable();
        //}
        public async Task<IEnumerable<Invoice>> GetAccountsReceivable(DateTime? startDate, DateTime? endDate, long? customerId, long? currencyId, long? sellerId, long? branchOfficeId)
        {

            return await this.GetAllAsync<Invoice>(y => y.AsNoTracking()
           .Include(x => x.Insurance).Include(x => x.InsurancePlan).Include(x => x.Currency).Include(x => x.Patient).Include(x => x.Appointment)
                .Include(x => x.BranchOffice).Include(x => x.TRNControl).Include(x => x.Seller)
            , x =>
             x.Active == true && (startDate.HasValue ? x.BillingDate >= startDate.Value : x.BillingDate > DateTime.MinValue) &&
            (endDate.HasValue ? x.BillingDate <= endDate.Value : x.BillingDate < DateTime.Now) &&
            (customerId.HasValue && customerId.Value > 0 ? x.CustomerId == customerId.Value : x.CustomerId > 0) &&
            (currencyId.HasValue && currencyId.Value > 0 ? x.CurrencyId == currencyId.Value : x.CurrencyId > 0) &&
            (sellerId.HasValue && sellerId.Value > 0 ? x.SellerId == sellerId.Value : x.SellerId > 0 || x.SellerId == null) &&
            (branchOfficeId.HasValue && branchOfficeId.Value > 0 ? x.BranchOfficeId == branchOfficeId.Value : x.BranchOfficeId > 0) &&
            x.OwedAmount > 0 && ((x.State == (char)Enums.BillingStates.Billed) || (x.State == (char)Enums.BillingStates.Paid))
            );
        }

        public async Task<IEnumerable<object>> GetAccountStatus(DateTime? startDate, DateTime? endDate, long? customerId, long? currencyId)
        {
            throw new NotImplementedException();
        }

        public async Task<Invoice> GetByInvoiceNumber(string invoiceNumber)
        {
            var invoice = await _Context.Invoices.Include(x=>x.Appointment).Include(x => x.Insurance).Include(x => x.InsurancePlan)
                .Include(x => x.Currency).Include(x => x.BranchOffice).Include(x => x.Seller).Include(x => x.InvoiceDetails).Include(x => x.TRNControl).Include(x => x.Appointment)
                .Include(x => x.Patient).AsNoTracking().FirstOrDefaultAsync(x => x.Active == true && x.InvoiceNumber.ToLower() == invoiceNumber.ToLower());
            invoice.InvoiceDetails = invoice.InvoiceDetails.Where(x => x.Active == true).ToList();
            return invoice;
        }

        public async Task<PagedList<Invoice>> GetPagedQuotes(int page, int size)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Invoice>> GetSales(DateTime? startDate, DateTime? endDate, long? customerId, long? currencyId, long? sellerId, long? branchOfficeId)
        {
         
            return await _Context.Invoices.AsNoTracking().Include(x => x.Patient).Include(x=>x.Insurance).Include(x=>x.InsurancePlan).Include(x => x.BranchOffice).Include(x => x.Appointment)
                .Include(x => x.Seller).Include(x=>x.Appointment).Include(x => x.Currency).Where(
                invoice => invoice.Active == true && (startDate.HasValue ? invoice.BillingDate >= startDate.Value : invoice.Id > 0) &&
             (branchOfficeId.HasValue && branchOfficeId.Value > 0 ? invoice.BranchOfficeId == branchOfficeId.Value : invoice.BranchOfficeId > 0) &&
         (endDate.HasValue ? invoice.BillingDate <= endDate.Value : invoice.Id > 0) && (customerId.HasValue && customerId.Value > 0 ? invoice.CustomerId == customerId.Value : invoice.Id > 0) &&
         (currencyId.HasValue && currencyId.Value > 0 ? invoice.CurrencyId == currencyId.Value : invoice.Id > 0) && (sellerId.HasValue && sellerId.Value > 0 ? invoice.SellerId == sellerId.Value : invoice.Id > 0)
         && (invoice.State != (char)Enums.BillingStates.Nulled)
                ).ToListAsync();
        }

        public async Task<List<InsurancCoverageDetail>> GetInsuranceCoverages(DateTime? startDate, DateTime? endDate, long? insuranceId, long? insurancePlanId, long? currencyId, long? branchOfficeId)
        {
            var validStates = new List<char>() 
            {
            (char)BillingStates.Paid,
            (char)BillingStates.FullPaid,
            (char)BillingStates.Billed,
            
            };
           
            var invoices = await _Context.Invoices.AsNoTracking().Include(x => x.Patient)
                .Include(x=>x.InvoiceDetails).ThenInclude(d=>d.Product)
                .Include(x => x.InvoiceDetails).ThenInclude(d => d.Doctor)
                .Include(x => x.Insurance).Include(x => x.InsurancePlan).Include(x => x.BranchOffice).Include(x => x.Appointment)
              .Include(x => x.Currency).Where(
                 invoice => invoice.Active == true && invoice.InsuranceId.HasValue == true && (startDate.HasValue ? invoice.BillingDate >= startDate.Value : invoice.Id > 0) &&
             (branchOfficeId.HasValue && branchOfficeId.Value > 0 ? invoice.BranchOfficeId == branchOfficeId.Value : invoice.BranchOfficeId > 0) &&
         (endDate.HasValue ? invoice.BillingDate <= endDate.Value : invoice.Id > 0) &&
         (insuranceId.HasValue && insuranceId.Value > 0 ? invoice.InsuranceId == insuranceId.Value : invoice.Id > 0) &&
         (insurancePlanId.HasValue && insurancePlanId.Value > 0 ? invoice.InsurancePlanId == insurancePlanId.Value : invoice.Id > 0) &&
         (currencyId.HasValue && currencyId.Value > 0 ? invoice.CurrencyId == currencyId.Value : invoice.Id > 0) &&
         (validStates.Contains(invoice.State))
                ).ToListAsync();

            List<InsurancCoverageDetail> result = new List<InsurancCoverageDetail>();
            invoices.ForEach(invoice => {
                var details = invoice.InvoiceDetails.Where(x => x.Active == true).Select(f => new InsurancCoverageDetail(f) { 
               Insurance=invoice.Insurance,
               InsurancePlan=invoice.InsurancePlan,
               InvoiceState=invoice.State,
               InsuranceCardId=invoice.InsuranceCardId,
               InvoiceNumber=invoice.InvoiceNumber,
               PatientName=invoice.Patient.NameAndCode,
               PatientCardId=invoice.Patient.CardId,
               Currency=invoice.Currency,
               Doctor=f.Doctor
                }).ToList();
                result.AddRange(details);
            });
            return result;
        }

        public async Task<IEnumerable<Invoice>> GetInvoicesToPay(long branchOfficeId = 0, long currencyId = 0, long customerId = 0)
        {
            var invoiceStates = new char[] { (char)Enums.BillingStates.Billed, (char)Enums.BillingStates.Paid };
           
            return await _Context.Invoices.AsNoTracking().Include(x => x.Insurance).Include(x => x.InsurancePlan).Include(x => x.Patient).ThenInclude(x => x.Insurance)
                .Include(x => x.Patient).ThenInclude(x => x.InsurancePlan)
                .Include(x => x.BranchOffice)
                .Include(x => x.Seller).Include(x=>x.Appointment).Include(x => x.Currency).Include(x => x.Appointment).Where(
                invoice => invoice.Active == true &&
          (customerId > 0 ? invoice.CustomerId == customerId : invoice.CustomerId > 0) &&
         (currencyId > 0 ? invoice.CurrencyId == currencyId : invoice.CurrencyId > 0) && (branchOfficeId > 0 ? invoice.BranchOfficeId == branchOfficeId : invoice.BranchOfficeId > 0)
         && (invoiceStates.Any(x => x == invoice.State)) && (invoice.OwedAmount > 0) && (invoice.PaidAmount < invoice.TotalAmount)
                ).ToListAsync();
        }
        private async Task SetInvoiceData(Invoice entity, bool isEditing = false)
        {
            entity.Id = isEditing ? entity.Id : 0;
            entity.Patient = entity.Patient != null && entity.Patient.Id > 0 ? entity.Patient : await _Context.Customers.Include(x => x.Insurance).Include(x => x.InsurancePlan).FirstOrDefaultAsync(s => s.Id == entity.CustomerId);
            entity.Currency = entity.Currency != null && entity.Currency.Id > 0 ? entity.Currency : await _Context.Currencies.FindAsync(entity.CurrencyId);
            _Context.Entry<Customer>(entity.Patient).State = EntityState.Detached;
            _Context.Entry<Currency>(entity.Currency).State = EntityState.Detached;
            entity.TRNType = entity.Patient.TRNType;
            entity.TRNControlId = entity.Patient.TRNControlId;
            entity.BillingDate = entity.InventoryModified ? DateTime.Now : entity.BillingDate;
            entity.Month = entity.BillingDate.HasValue ? (Enums.Month)entity.BillingDate.Value.Month : (Enums.Month.NotSet);
            if (!entity.InventoryModified)
                entity.BillingDate = null;
            entity.InvoiceNumber = entity.InventoryModified ? SequencesHelper.CreateSequenceControl(dataRepositoryFactory, Enums.SequenceTypes.Invoices) : "";
            entity.DocumentNumber = !entity.InventoryModified && string.IsNullOrEmpty(entity.DocumentNumber) ? SequencesHelper.CreateSequenceControl(dataRepositoryFactory, Enums.SequenceTypes.Quotes) : entity.DocumentNumber;
            entity.SellerId = entity.SellerId.HasValue && entity.SellerId <= 0 ? null : entity.SellerId;
            entity.CashRegisterId = entity.CashRegisterId.HasValue && entity.CashRegisterId <= 0 ? null : entity.CashRegisterId;
            entity.WarehouseId = entity.WarehouseId.HasValue && entity.WarehouseId == 0 ? null : entity.WarehouseId;
            entity.State = entity.InventoryModified ? (char)Enums.BillingStates.Billed : (char)Enums.BillingStates.Quoted;
            entity.Seller = entity.Seller == null && entity.SellerId.HasValue && entity.SellerId.Value > 0 ?
                      await _Context.Sellers.FindAsync(entity.SellerId.Value) : entity.Seller;
            if (entity.Seller != null)
                _Context.Entry<Seller>(entity.Seller).State = EntityState.Detached;
        }

         void SetSellerComisions(Invoice entity, List<InvoiceDetail> details)
        {
            if (entity.Seller != null && entity.Seller.Id > 0 && entity.InventoryModified)
            {
                decimal comision = 0;
                details.ForEach( d =>
                {

                    comision = entity.Seller.FixedComission ? ((d.BeforeTaxesAmount) * entity.Seller.ComissionRate) : 0;
                    if (entity.Seller.ComissionByProduct)
                    {

                        d.Product = d.Product ??  _Context.Products.AsNoTracking().FirstOrDefault(x => x.Active == true && x.Id == d.ProductId);
                        comision += (d.Product?.SellerRate * d.BeforeTaxesAmount).Value;

                    }
                    d.SellerRate = comision;
                });
                entity.SellerRate = details.Sum(x => x.SellerRate);

            }
        }

        async Task<Result<Invoice>> SetCustomerBalance(Invoice entity, IDbContextTransaction transaction)
        {
            var result = new Result<Invoice>(0, 0, "ok_msg", new List<Invoice> { entity });
            if (entity.OwedAmount > 0 && entity.InventoryModified)
            {
                var balance = await _Context.CustomersBalance.AsNoTracking().FirstOrDefaultAsync(x => x.CustomerId == entity.CustomerId && x.CurrencyId == entity.CurrencyId && x.Active == true) ??
                    new CustomerBalance() { CustomerId = entity.CustomerId, CurrencyId = entity.CurrencyId, Id = 0, Active = true };

                balance.OwedAmount += entity.OwedAmount;
                if (balance.CurrencyId == entity.Patient.CurrencyId && entity.Patient.CreditAmountLimit > 0 && balance.OwedAmount > entity.Patient.CreditAmountLimit)
                {
                    if (transaction != null)
                  await      transaction.RollbackAsync();
                    return new Result<Invoice>(-1, -1, "creditLimitReached_msg");
                }
                if (balance.Id > 0)
                    _Context.CustomersBalance.Update(balance);
                else
                    _Context.CustomersBalance.Add(balance);

             await   _Context.SaveChangesAsync();

            }

            return result;
        }
        public override async Task<Result<Invoice>> AddAsync(Invoice entity)
        {
            Result<Invoice> result = new Result<Invoice>(-1, -1, "error_msg");
            using (var transaction = _Context.Database.BeginTransaction())
            {
                try
                {
                  await  SetInvoiceData(entity);
                    var trnResult = entity.InventoryModified ? await CreateTRN(entity) : new Result<Invoice>();

                    if (trnResult.Status < 0)
                    {
                        await transaction.RollbackAsync();
                        return trnResult;
                    }
                    entity = entity.InventoryModified ? trnResult.Data.FirstOrDefault() : entity;

                    CreditNote appliedCreditNote = new CreditNote();
                    if (!string.IsNullOrEmpty(entity.AppliedCreditNote) && entity.InventoryModified)
                        appliedCreditNote = await _Context.CreditNotes.AsNoTracking().FirstOrDefaultAsync(x => x.Sequence == entity.AppliedCreditNote);

                    if (entity.InvoiceDetails.Count <= 0)
                    {
                       await transaction.RollbackAsync();
                        return new Result<Invoice>(-1, -1, "emptyInvoice_msg");
                    }

                    var details = SetDetailsProperties(entity);
                    entity.InvoiceDetails = null;
                    SetSellerComisions(entity, details);
                     SetInvoiceAmounts(entity, details);
                    var tempBranchOfiice = entity.BranchOffice ?? await _Context.BranchOffices.FindAsync(entity.BranchOfficeId);
                    _Context.Entry<BranchOffice>(tempBranchOfiice).State = EntityState.Detached;
                    entity.State = (entity.PaidAmount == (entity.TotalAmount - entity.InsuranceCoverageAmount) && entity.OwedAmount == 0) ? (char)Enums.BillingStates.FullPaid : (entity.PaidAmount > 0) ? (char)Enums.BillingStates.Paid : entity.State;
                    if (entity.InventoryModified)
                    {
                        var creditNoteResult = InvoiceHelper.ApplyCreditNote(entity, appliedCreditNote, out appliedCreditNote);
                        if (creditNoteResult.Status < 0)
                        {
                           await transaction.RollbackAsync();
                            return creditNoteResult;
                        }
                        else
                            entity = creditNoteResult.Data.FirstOrDefault();
                    }

                    var customerBalanceResult = await SetCustomerBalance(entity, transaction);
                    if (customerBalanceResult.Status < 0)
                        return customerBalanceResult;

                    entity.ReturnedAmount = entity.ReturnedAmount < 0 ? 0 : entity.ReturnedAmount;
                    entity.Patient = null;
                    entity.Currency = null;
                    entity.Insurance = null;
                    entity.InsurancePlan = null;
                    entity.Appointment = null;
                    entity.BranchOffice = null;
                    entity.Payments = new List<CustomerPayment>();
                    entity.Seller = null;
                    entity.Taxes = new List<InvoiceTax>();
                    entity.TRNControl = null;
                    entity.InvoiceDetails = null;
                    var invoice = base.Add(entity).Data.FirstOrDefault();
                    _Context.Entry<Invoice>(invoice).State = EntityState.Detached;
                    if (!string.IsNullOrEmpty(appliedCreditNote.Sequence))
                    {
                        _Context.CreditNotes.Update(appliedCreditNote);
                     await   _Context.SaveChangesAsync();
                    }

                    details.ForEach(d =>
                    {
                        d.Product = null;
                        d.Doctor = null;
                        d.MedicalSpeciality = null;
                        d.Active = true;
                        d.Unit = null;
                        d.Invoice = null;
                        d.Date = entity.BillingDate.HasValue ? entity.BillingDate.Value : DateTime.Now;
                        d.BranchOfficeId = entity.BranchOfficeId;
                        d.InvoiceId = entity.Id;
                        
                    });
                    entity.InvoiceDetails = details;
                    if (entity.InventoryModified)
                        InvoiceDetailsHelper.UpdateInvoiceTaxes(entity, dataRepositoryFactory);
                    entity.InvoiceDetails = null;
                    invoice.BranchOffice = tempBranchOfiice;

                    var branchOffice = _Context.BranchOffices.AsNoTracking().FirstOrDefault(x => x.Id == entity.BranchOfficeId && x.Active == true);
                    entity.InvoiceDetails = details;
                    Helpers.InvoiceDetailsHelper.AddDetails(entity, branchOffice, dataRepositoryFactory, false);
                    CreatePayment(entity);
                    var appointmentResult = await UpdateAppointmentStatus(entity);
                    if (appointmentResult.Status < 0)
                    {
                      await  transaction.RollbackAsync();
                        return new Result<Invoice>(-1, -1, appointmentResult.Message);
                    }
                   await transaction.CommitAsync();
                    result = new Result<Invoice>(entity.Id, 0, "ok_msg", new List<Invoice>() { invoice });

                    return result;
                }
                catch (Exception ex)
                {
                    result = new Result<Invoice>(-1, -1, ex.Message, null, new Exception(ex.Message));
                  await  transaction.RollbackAsync();
                    return result;
                }
            }


        }

        private async Task<Result<object>> UpdateAppointmentStatus(Invoice invoice)
        {
            Result<object> result = new Result<object>(0, 0, "ok_msg");
            if (invoice.AppointmentId.HasValue && invoice.AppointmentId.Value > 0)
            {
                var appointment = await _Context.Appointments.AsNoTracking().FirstOrDefaultAsync(x => x.Active == true && x.Id == invoice.AppointmentId.Value);
                if (appointment == null)
                    return new Result<object>(-1, -1, "invalidAppointment_msg");

                appointment.State = (char)AppointmentStates.Billed;
                _Context.Appointments.Update(appointment);
               await _Context.SaveChangesAsync();
                return new Result<object>(invoice.Id, 0, "ok_msg");
            }

            return result;
        }

        List<InvoiceDetail> SetDetailsProperties(Invoice entity)
        {

            var details = entity.InvoiceDetails;
            details.ForEach(d =>
            {
                d.Product = d.Product == null ? _Context.Products.AsNoTracking().Include(x => x.ProductUnits).ThenInclude(x => x.Unit).Include(x => x.Taxes).ThenInclude(x => x.Tax).FirstOrDefault(x => x.Active == true && x.Id == d.ProductId) : d.Product;
                d.Doctor =!d.DoctorId.HasValue?null: _Context.Users.AsNoTracking().FirstOrDefault(x => x.Active == true && x.UserId == d.DoctorId);
                d.MedicalSpeciality = d.MedicalSpecialityId.HasValue ? _Context.MedicalSpecialities.AsNoTracking().FirstOrDefault(x => x.Active == true && x.Id == d.MedicalSpecialityId) : null;
                d.Product.Taxes = d.Product.Taxes == null ? _Context.ProductTaxes.AsNoTracking().Include(x => x.Tax).Where(x => x.Active == true && x.ProductId == d.ProductId) : d.Product.Taxes;
                d.Product.ProductUnits = d.Product.ProductUnits != null ? d.Product.ProductUnits.Where(x => x.Active) : d.Product.ProductUnits;
                d.Amount = d.Amount > 0 ? d.Amount : (d.UnitId.HasValue ? (d.Product.Price / Convert.ToDecimal(d.Product.ProductUnits.FirstOrDefault(x => x.UnitId == d.UnitId.Value)?.Equivalence)) : d.Product.Price);
                d.Cost = d.Cost > 0 ? d.Cost : d.Product.Cost * d.Quantity;
                d.BeforeTaxesAmount = d.BeforeTaxesAmount > 0 ? d.BeforeTaxesAmount : (d.Amount * d.Quantity);
                d.DiscountAmount = d.DiscountAmount > 0 ? d.DiscountAmount : d.BeforeTaxesAmount * (d.DiscountRate > 1 ? d.DiscountRate / 100 : d.DiscountRate);
                d.TaxesAmount = d.TaxesAmount > 0 ? d.TaxesAmount : (d.BeforeTaxesAmount - d.DiscountAmount) * d.Product.Taxes.Sum(t => t.Tax.Rate);
                d.TotalAmount = d.TotalAmount > 0 ? d.TotalAmount : d.BeforeTaxesAmount + d.TaxesAmount - d.DiscountAmount - d.CreditNoteAmount;
                d.PatientPaymentAmount = d.TotalAmount - d.InsuranceCoverageAmount;
            });

            return details;
        }

         void SetInvoiceAmounts(Invoice entity, List<InvoiceDetail> details)
        {
            entity.InvoiceDetails = null;
            entity.BeforeTaxesAmount = details.Sum(x => x.BeforeTaxesAmount);
            entity.Cost = details.Sum(x => x.Cost);
            entity.DiscountAmount = details.Sum(x => x.DiscountAmount);
            entity.DiscountRate = details.Average(x => x.DiscountRate);
            entity.TaxesAmount = details.Sum(x => x.TaxesAmount);
            entity.InsuranceCoverageAmount = details.Sum(x => x.InsuranceCoverageAmount);

            entity.ReturnedAmount = entity.ReceivedAmount - entity.TotalAmount;
            entity.TotalAmount = entity.BeforeTaxesAmount + entity.TaxesAmount - entity.DiscountAmount;
            entity.PatientPaymentAmount = entity.TotalAmount - entity.InsuranceCoverageAmount;
            entity.ExchangeRate = entity.Currency.ExchangeRate;
            entity.OwedAmount = entity.TotalAmount - entity.InsuranceCoverageAmount - entity.PaidAmount - entity.AppliedCreditNoteAmount;
            entity.ReturnedAmount = entity.ReceivedAmount - entity.TotalAmount;

        }

        void CreatePayment(Invoice entity)
        {
            if (entity.PaidAmount > 0 && entity.Payments != null && entity.Payments.Count > 0 && entity.InventoryModified)
            {
                string sequencePayment = SequencesHelper.CreatePaymentControl(this.dataRepositoryFactory);
                foreach (var payment in entity.Payments)
                {
                    payment.InvoiceNumber = entity.InvoiceNumber;
                    payment.CreatedBy = entity.CreatedBy;
                    payment.CreatedDate = entity.CreatedDate;
                    payment.CurrentOwedAmount = payment.OutstandingAmount;
                    payment.Sequence = sequencePayment;
                    InvoiceHelper.ApplyInvoicePayment(payment, this.dataRepositoryFactory.GetCustomDataRepositories<ICustomerPaymentRepository>());
                }
            }
        }
        public async Task<Result<Invoice>> AddWithoutTransaction(Invoice entity)
        {
            Result<Invoice> result = new Result<Invoice>(-1, -1, "error_msg");
            try
            {

               await SetInvoiceData(entity);
                var trnResult = entity.InventoryModified ? await CreateTRN(entity) : new Result<Invoice>();

                if (trnResult.Status < 0)
                {
                    return trnResult;
                }
                entity = entity.InventoryModified ? trnResult.Data.FirstOrDefault() : entity;

                CreditNote appliedCreditNote = new CreditNote();
                if (!string.IsNullOrEmpty(entity.AppliedCreditNote) && entity.InventoryModified)
                    appliedCreditNote = await _Context.CreditNotes.AsNoTracking().FirstOrDefaultAsync(x => x.Sequence == entity.AppliedCreditNote);

                if (entity.InvoiceDetails.Count <= 0)
                {
                    return new Result<Invoice>(-1, -1, "emptyInvoice_msg");
                }


                var details = SetDetailsProperties(entity);


                SetSellerComisions(entity, details);
                SetInvoiceAmounts(entity, details);

                var tempBranchOfiice = entity.BranchOffice ?? await _Context.BranchOffices.FindAsync(entity.BranchOfficeId);
                _Context.Entry<BranchOffice>(tempBranchOfiice).State = EntityState.Detached;
                entity.State = (entity.PaidAmount == (entity.TotalAmount - entity.InsuranceCoverageAmount) && entity.OwedAmount == 0) ? (char)Enums.BillingStates.FullPaid : (entity.PaidAmount > 0) ? (char)Enums.BillingStates.Paid : entity.State;
                if (entity.InventoryModified)
                {
                    var creditNoteResult = InvoiceHelper.ApplyCreditNote(entity, appliedCreditNote, out appliedCreditNote);
                    if (creditNoteResult.Status < 0)
                    {
                        return creditNoteResult;
                    }
                    else
                        entity = creditNoteResult.Data.FirstOrDefault();
                }

                var customerBalanceResult = await SetCustomerBalance(entity, null);
                if (customerBalanceResult.Status < 0)
                    return customerBalanceResult;
                entity.ReturnedAmount = entity.ReturnedAmount < 0 ? 0 : entity.ReturnedAmount;
                entity.Patient = null;
                entity.Appointment = null;
                entity.Currency = null;
                entity.BranchOffice = null;
                entity.Payments = new List<CustomerPayment>();
                entity.Seller = null;
                entity.Taxes = new List<InvoiceTax>();
                entity.TRNControl = null;
                entity.InvoiceDetails = null;
                var invoice = base.Add(entity).Data.FirstOrDefault();
                _Context.Entry<Invoice>(invoice).State = EntityState.Detached;
                if (!string.IsNullOrEmpty(appliedCreditNote.Sequence))
                {
                    _Context.CreditNotes.Update(appliedCreditNote);
                  await  _Context.SaveChangesAsync();
                }

                details.ForEach(d =>
                {
                    d.Product = null;
                    d.Date = entity.BillingDate.HasValue ? entity.BillingDate.Value : DateTime.Now;
                    d.BranchOfficeId = entity.BranchOfficeId;
                    d.InvoiceId = entity.Id;
                });
                entity.InvoiceDetails = details;
                if (entity.InventoryModified)
                    InvoiceDetailsHelper.UpdateInvoiceTaxes(entity, dataRepositoryFactory);
                entity.InvoiceDetails = null;
                invoice.BranchOffice = tempBranchOfiice;

                var branchOffice = await _Context.BranchOffices.AsNoTracking().FirstOrDefaultAsync(x => x.Id == entity.BranchOfficeId && x.Active == true);
                entity.InvoiceDetails = details;
                Helpers.InvoiceDetailsHelper.AddDetails(entity, branchOffice, dataRepositoryFactory, false);
                CreatePayment(entity);
                var appointmentResult = await UpdateAppointmentStatus(entity);
                if (appointmentResult.Status < 0)
                {

                    return new Result<Invoice>(-1, -1, appointmentResult.Message);
                }
                result = new Result<Invoice>(entity.Id, 0, "ok_msg", new List<Invoice>() { invoice });

                return result;
            }
            catch (Exception ex)
            {
                result = new Result<Invoice>(-1, -1, ex.Message, null, new Exception(ex.Message));

                return result;
            }



        }

        private async Task<Result<Invoice>> CreateTRN(Invoice obj)
        {
            if (!string.IsNullOrEmpty(obj.TRNType) && obj.TRNType != "N/A")
            {

                var trnControl = await _Context.TRNsControl.AsNoTracking().FirstOrDefaultAsync(x => x.Active == true && x.Type == obj.TRNType);
                if (trnControl == null || trnControl.Quantity <= 0)
                    return new Result<Invoice>(-1, -1, "trnNotAvailable_msg");

                obj.TRN = $"{trnControl.Series}{trnControl.Type}{string.Format("{0:00000000}", trnControl.Sequence)}";
                trnControl.Sequence++;
                trnControl.Quantity--;
                trnControl.NumericControl++;
                _Context.TRNsControl.Update(trnControl);
             await   _Context.SaveChangesAsync();
                return new Result<Invoice>(0, 0, "ok_msg", new List<Invoice>() { obj });
            }
            return new Result<Invoice>(0, 0, "ok_msg", new List<Invoice>() { obj });
        }

        void UpdateDetails(Invoice entity, Invoice dbEntity, List<InvoiceDetail> oldDetails)
        {
            if (!dbEntity.InventoryModified && !entity.InventoryModified)
                oldDetails.ForEach(d =>
                {
                    if (d.Id > 0)
                    {
                        var newDetail = entity.InvoiceDetails.FirstOrDefault(x => x.Id == d.Id);
                        if (newDetail != null)
                        {
                            var product = _Context.Products.Include(x => x.ProductUnits).ThenInclude(x => x.Unit).Include(x => x.Taxes).ThenInclude(y => y.Tax).AsNoTracking().FirstOrDefault(x => x.Id == newDetail.ProductId && x.Active == true);
                            d.Product = null;
                            d.Unit = null;
                            d.MedicalSpeciality = null;
                            d.Doctor = null;
                            d.InvoiceId = entity.Id;
                            d.WarehouseId = entity.WarehouseId;
                            d.ProductId = newDetail.ProductId;
                            d.Quantity = newDetail.Quantity;
                            d.UnitId = newDetail.UnitId;
                            d.Active = true;
                            d.Date = entity.BillingDate.HasValue ? entity.BillingDate.Value : entity.CreatedDate;
                            d.Cost = d.UnitId.HasValue ? Convert.ToDecimal(product.ProductUnits.FirstOrDefault(x => x.UnitId == d.UnitId && d.Active == true)?.CostPrice) : product.Cost;

                            d.Amount = d.Amount > 0 ? d.Amount : (d.UnitId.HasValue ? product.Price / Convert.ToDecimal(product.ProductUnits.FirstOrDefault(x => x.UnitId == d.UnitId.Value)?.Equivalence) : product.Price);
                            d.BeforeTaxesAmount = (d.Amount * d.Quantity);
                            d.DiscountAmount = d.BeforeTaxesAmount * (d.DiscountRate > 1 ? d.DiscountRate / 100 : d.DiscountRate);
                            d.TaxesAmount = (d.BeforeTaxesAmount - d.DiscountAmount) * product.Taxes.Sum(t => t.Tax.Rate);
                            d.TotalAmount = d.BeforeTaxesAmount + d.TaxesAmount - d.DiscountAmount - d.CreditNoteAmount;
                            _Context.InvoiceDetails.Update(d);

                        }
                        else
                        {
                            _Context.InvoiceDetails.Remove(d);
                        }
                    }
                    else
                    {
                        var product = _Context.Products.Include(x => x.ProductUnits).ThenInclude(x => x.Unit).Include(x => x.Taxes).ThenInclude(y => y.Tax).AsNoTracking().FirstOrDefault(x => x.Id == d.ProductId && x.Active == true);
                        d.Product = null;
                        d.MedicalSpeciality = null;
                        d.Doctor = null;
                        d.Unit = null;
                        d.InvoiceId = entity.Id;
                        d.WarehouseId = entity.WarehouseId;
                        d.Active = true;
                        d.Date = entity.BillingDate.HasValue ? entity.BillingDate.Value : entity.CreatedDate;
                        d.Cost = d.UnitId.HasValue ? Convert.ToDecimal(product.ProductUnits.FirstOrDefault(x => x.UnitId == d.UnitId && d.Active == true)?.CostPrice) : product.Cost;
                        d.Amount = d.UnitId.HasValue ? Convert.ToDecimal(product.ProductUnits.FirstOrDefault(x => x.UnitId == d.UnitId.Value)?.SellingPrice) : product.Price;
                        d.BeforeTaxesAmount = (d.Amount * d.Quantity);
                        d.DiscountAmount = d.BeforeTaxesAmount * (d.DiscountRate > 1 ? d.DiscountRate / 100 : d.DiscountRate);
                        d.TaxesAmount = (d.BeforeTaxesAmount - d.DiscountAmount) * product.Taxes.Sum(t => t.Tax.Rate);
                        d.TotalAmount = d.BeforeTaxesAmount + d.TaxesAmount - d.DiscountAmount - d.CreditNoteAmount;
                        d.PatientPaymentAmount = d.TotalAmount - d.InsuranceCoverageAmount;
                        _Context.InvoiceDetails.Add(d);
                    }



                    _Context.SaveChanges();

                });
            else if (!dbEntity.InventoryModified && entity.InventoryModified)
            {
                _Context.InvoiceDetails.RemoveRange(oldDetails.Where(x => x.Id > 0).Select(x => new InvoiceDetail()
                {
                    Id = x.Id,
                    ProductId = x.ProductId,
                    UnitId = x.UnitId,
                    BranchOfficeId = x.BranchOfficeId,
                    InvoiceId = x.InvoiceId,
                    ParentId = x.ParentId,
                    WarehouseId = x.WarehouseId
                }));
                _Context.SaveChanges();
                oldDetails.ForEach(d =>
                {
                    d.Id = 0;
                    d.Amount = d.UnitId.HasValue ? Convert.ToDecimal(d.Product.ProductUnits.FirstOrDefault(x => x.UnitId == d.UnitId.Value)?.SellingPrice) : d.Product.Price;
                    d.BeforeTaxesAmount = (d.Amount * d.Quantity);
                    d.DiscountAmount = d.BeforeTaxesAmount * (d.DiscountRate > 1 ? d.DiscountRate / 100 : d.DiscountRate);
                    d.TaxesAmount = (d.BeforeTaxesAmount - d.DiscountAmount) * d.Product.Taxes.Sum(t => t.Tax.Rate);
                    d.TotalAmount = d.BeforeTaxesAmount + d.TaxesAmount - d.DiscountAmount - d.CreditNoteAmount;
                    d.PatientPaymentAmount = d.TotalAmount - d.InsuranceCoverageAmount;
                });
                entity.InvoiceDetails = oldDetails;
                var branchOffice = _Context.BranchOffices.Find(entity.BranchOfficeId);
                _Context.Entry<BranchOffice>(branchOffice).State = EntityState.Detached;
                Helpers.InvoiceDetailsHelper.AddDetails(entity, branchOffice, dataRepositoryFactory, false);
            }
            else
            {

                var branchOffice = _Context.BranchOffices.Find(entity.BranchOfficeId);
                _Context.Entry<BranchOffice>(branchOffice).State = EntityState.Detached;
                Helpers.InvoiceDetailsHelper.UpdateDetails(entity, branchOffice, dataRepositoryFactory);
            }
        }
        public override async Task< Result<Invoice>> UpdateAsync(Invoice entity, bool getFromDb = true)
        {
            Result<Invoice> result = new Result<Invoice>(-1, -1, "error_msg");
            using (var trans = await _Context.Database.BeginTransactionAsync())
            {
                try
                {
                    // SetInvoiceData(entity);

                    var newDetails = SetDetailsProperties(entity);
                    var dbEntity = await _Context.Invoices.FindAsync(entity.Id);
                    _Context.Entry<Invoice>(dbEntity).State = EntityState.Detached;
                    var oldDetails = await _Context.InvoiceDetails.AsNoTracking()
                        .Include(x => x.Product).ThenInclude(x => x.Taxes).ThenInclude(x => x.Tax)
                        .Include(x => x.Product).ThenInclude(x => x.ProductUnits)
                        .Where(x => x.Active == true && x.InvoiceId == entity.Id).ToListAsync();
                    dbEntity.WarehouseId = entity.WarehouseId.HasValue && entity.WarehouseId == 0 ? null : entity.WarehouseId;
                    dbEntity.BranchOffice = null;
                    dbEntity.Appointment = null;
                    dbEntity.Patient = null;
                    dbEntity.Seller = null;
                    dbEntity.State = entity.InventoryModified ? (char)Enums.BillingStates.Billed : (char)Enums.BillingStates.Quoted;
                    oldDetails.AddRange(entity.InvoiceDetails.Where(x => x.Id == 0));
                    UpdateDetails(entity, dbEntity, oldDetails);

                    dbEntity.BeforeTaxesAmount = newDetails.Sum(x => x.BeforeTaxesAmount);
                    dbEntity.Cost = newDetails.Sum(x => x.Cost);
                    dbEntity.DiscountAmount = newDetails.Sum(x => x.DiscountAmount);
                    dbEntity.DiscountRate = newDetails.Average(x => x.DiscountRate);
                    dbEntity.TaxesAmount = newDetails.Sum(x => x.TaxesAmount);
                    dbEntity.TotalAmount = newDetails.Sum(x => x.TotalAmount);
                    dbEntity.InsuranceCoverageAmount = newDetails.Sum(x => x.InsuranceCoverageAmount);
                    dbEntity.OwedAmount = dbEntity.TotalAmount - entity.PaidAmount - dbEntity.InsuranceCoverageAmount;
                    dbEntity.InventoryModified = entity.InventoryModified;
                    dbEntity.ReturnedAmount = dbEntity.ReceivedAmount - dbEntity.TotalAmount - dbEntity.InsuranceCoverageAmount;
                    dbEntity.DocumentNumber = string.IsNullOrEmpty(dbEntity.DocumentNumber) && !entity.InventoryModified ? await this.sequenceManagerRepository.CreateSequence(Enums.SequenceTypes.Quotes) : dbEntity.DocumentNumber;
                    dbEntity.InvoiceNumber = string.IsNullOrEmpty(dbEntity.InvoiceNumber) && entity.InventoryModified ? await this.sequenceManagerRepository.CreateSequence(Enums.SequenceTypes.Invoices) : dbEntity.InvoiceNumber;
                    dbEntity.InvoiceDetails = null;
                    _Context.Invoices.Update(dbEntity);
                 await   _Context.SaveChangesAsync();
                  await  trans.CommitAsync();
                    result = new Result<Invoice>(entity.Id, 0, "ok_msg");
                }
                catch (Exception ex)
                {
                 await   trans.RollbackAsync();
                    result = new Result<Invoice>(-1, -1, ex.Message, null, new Exception(ex.Message));
                }
            }

            return result;
        }

        public async Task<Result<Invoice>> UpdateWithoutTransaction(Invoice entity, bool getFromDb = true)
        {
            Result<Invoice> result = new Result<Invoice>(-1, -1, "error_msg");

            try
            {
                // SetInvoiceData(entity);

                var newDetails = SetDetailsProperties(entity);
                var dbEntity = await _Context.Invoices.FindAsync(entity.Id);
                _Context.Entry<Invoice>(dbEntity).State = EntityState.Detached;
                var oldDetails = await _Context.InvoiceDetails.AsNoTracking()
                    .Include(x => x.Product).ThenInclude(x => x.Taxes).ThenInclude(x => x.Tax)
                    .Include(x => x.Product).ThenInclude(x => x.ProductUnits)
                    .Where(x => x.Active == true && x.InvoiceId == entity.Id).ToListAsync();
                dbEntity.WarehouseId = entity.WarehouseId.HasValue && entity.WarehouseId == 0 ? null : entity.WarehouseId;
                dbEntity.BranchOffice = null;
                dbEntity.Patient = null;
                dbEntity.Appointment = null;
                dbEntity.Seller = null;
                dbEntity.State = entity.InventoryModified ? (char)Enums.BillingStates.Billed : (char)Enums.BillingStates.Quoted;
                oldDetails.AddRange(entity.InvoiceDetails.Where(x => x.Id == 0));
                UpdateDetails(entity, dbEntity, oldDetails);

                dbEntity.BeforeTaxesAmount = newDetails.Sum(x => x.BeforeTaxesAmount);
                dbEntity.Cost = newDetails.Sum(x => x.Cost);
                dbEntity.DiscountAmount = newDetails.Sum(x => x.DiscountAmount);
                dbEntity.DiscountRate = newDetails.Average(x => x.DiscountRate);
                dbEntity.TaxesAmount = newDetails.Sum(x => x.TaxesAmount);
                dbEntity.TotalAmount = newDetails.Sum(x => x.TotalAmount);
                dbEntity.InsuranceCoverageAmount = newDetails.Sum(x => x.InsuranceCoverageAmount);
                dbEntity.PatientPaymentAmount = dbEntity.TotalAmount - dbEntity.InsuranceCoverageAmount;
                dbEntity.OwedAmount = dbEntity.TotalAmount - entity.PaidAmount - entity.InsuranceCoverageAmount;
                dbEntity.InventoryModified = entity.InventoryModified;
                dbEntity.ReturnedAmount = dbEntity.ReceivedAmount - entity.TotalAmount - dbEntity.InsuranceCoverageAmount;
                dbEntity.DocumentNumber = string.IsNullOrEmpty(dbEntity.DocumentNumber) && !entity.InventoryModified ? await this.sequenceManagerRepository.CreateSequence(Enums.SequenceTypes.Quotes) : dbEntity.DocumentNumber;
                dbEntity.InvoiceNumber = string.IsNullOrEmpty(dbEntity.InvoiceNumber) && entity.InventoryModified ? await this.sequenceManagerRepository.CreateSequence(Enums.SequenceTypes.Invoices) : dbEntity.InvoiceNumber;
                dbEntity.InvoiceDetails = null;
                _Context.Invoices.Update(dbEntity);
               await  _Context.SaveChangesAsync();
                result = new Result<Invoice>(entity.Id, 0, "ok_msg");
            }
            catch (Exception ex)
            {
                result = new Result<Invoice>(-1, -1, ex.Message, null, new Exception(ex.Message));
            }


            return result;
        }

        public override async Task<Result<Invoice>> RemoveAsync(long id)
        {
            var result = new Result<Invoice>(-1, -1, "error_msg");

            using (var trans = await _Context.Database.BeginTransactionAsync())
            {
                try
                {



                    var invoice = await _Context.Invoices.FindAsync(id);
                    _Context.Entry<Invoice>(invoice).State = EntityState.Detached;
                    var validStates = new char[] { (char)Enums.BillingStates.Billed, (char)Enums.BillingStates.Quoted };
                    if (!validStates.Contains(invoice.State))
                    {
                     await   trans.RollbackAsync();
                        return new Result<Invoice>(-1, -1, "leadIsBilled_msg");
                    }
                    else
                        CancelInvoice(invoice);
                    var appointment = invoice.AppointmentId.HasValue && invoice.AppointmentId.Value > 0 ? await _Context.Appointments.AsNoTracking().FirstOrDefaultAsync(x => x.Id == invoice.AppointmentId.Value) : null;
                    if (appointment != null)
                    {
                        appointment.State = await _Context.PatientCheckups.AnyAsync(x => x.Active == true && x.AppointmentId == appointment.Id) ? (char)AppointmentStates.InProgress : (char)AppointmentStates.Scheduled;
                        _Context.Appointments.Update(appointment);
                      await  _Context.SaveChangesAsync();
                    }
                   await trans.CommitAsync();
                    result = new Result<Invoice>(id, 0, "ok_msg");
                }
                catch (Exception ex)
                {
                  await  trans.RollbackAsync();
                    result = new Result<Invoice>(-1, -1, "error_msg", null, new Exception(ex.Message));
                }
            }

            return result;
        }

        private void CancelInvoice(Invoice invoiceLead)
        {
            var details = _Context.InvoiceDetails.AsNoTracking().Include(x => x.Product).Include(x => x.Unit).Where(x => x.Active == true && x.InvoiceId == invoiceLead.Id).ToList();
            if (invoiceLead.BillingState != Enums.BillingStates.Quoted && invoiceLead.BillingState != Enums.BillingStates.Nulled && invoiceLead.InventoryModified)
            {

                details.ForEach(d =>
                {
                    InventoryHelper.AddInventory(d, invoiceLead, dataRepositoryFactory);

                    var children = _Context.InvoiceDetails.AsNoTracking().Include(x => x.Product).Include(x => x.Unit).Where(x => x.Active == true && x.ParentId == d.Id).ToList();
                    children.ForEach(d =>
                    {
                        InventoryHelper.AddInventory(d, invoiceLead, dataRepositoryFactory);
                    });
                });

            }
            details.ForEach(d =>
            {
                d.Product = null;
                d.Unit = null;
            });
            invoiceLead.State = (char)Enums.BillingStates.Nulled;
            invoiceLead.InventoryModified = false;
            _Context.Invoices.Update(invoiceLead);
            _Context.SaveChanges();

            if (!string.IsNullOrEmpty(invoiceLead.DocumentNumber))
            {
                var parentQuote = _Context.Invoices.AsNoTracking().FirstOrDefault(x => x.Active == true && x.State == (char)BillingStates.Converted && x.DocumentNumber == invoiceLead.DocumentNumber);
                if (parentQuote != null)
                {
                    parentQuote.State = (char)BillingStates.Quoted;
                    base.Update(parentQuote);
                }
            }

            var taxes = _Context.InvoicesTaxes.AsNoTracking().Where(x => x.Active == true && x.InvoiceNumber.ToLower() == invoiceLead.InvoiceNumber.ToLower()).ToList();
            if (taxes != null)
            {
                _Context.InvoicesTaxes.RemoveRange(taxes);
                _Context.SaveChanges();
            }
        }

        public async Task<List<CompanyStateModel>> GetCompanyStatus(DateTime? initialDate, DateTime? endDate)
        {

            List<CompanyStateModel> result = new List<CompanyStateModel>();
            var expenses = await _Context.Expenses.Include(x => x.Payments).ThenInclude(p => p.Currency)
                .Include(x => x.Supplier)
               .Include(x => x.Currency).AsNoTracking().Where(x => x.Active == true && (x.State == (char)BillingStates.Billed || x.State == (char)BillingStates.Paid || x.State == (char)BillingStates.FullPaid)
                && x.Date >= (initialDate.HasValue ? initialDate.Value : DateTime.MinValue) && x.Date <= (endDate.HasValue ? endDate.Value : DateTime.Now)).ToListAsync();

            var invoices = await _Context.Invoices.Include(x => x.Payments).ThenInclude(p => p.Currency)
                .Include(x => x.Patient).Include(x => x.Insurance).Include(x => x.InsurancePlan)
                .Include(x=>x.Appointment).Include(x => x.Currency).AsNoTracking().Where(x => x.Active == true && (x.State == (char)BillingStates.Billed || x.State == (char)BillingStates.Paid || x.State == (char)BillingStates.FullPaid)
                  && x.BillingDate >= (initialDate.HasValue ? initialDate.Value : DateTime.MinValue) && x.BillingDate <= (endDate.HasValue ? endDate.Value : DateTime.Now)).ToListAsync();

            expenses.ForEach(expense =>
            {
                result.Add(new CompanyStateModel()
                {
                    CompanyOwedAmount = expense.TotalAmount,
                    CustomersOwedAmount = 0,
                    IncomeAmount = 0,
                    OutcomeAmount = 0,
                    CurrencyCode = expense.Currency.Code,
                    CurrencyId = expense.CurrencyId,
                    CurrencyName = expense.Currency.Name,
                    CustomerName = string.Empty,
                    Date = expense.Date,
                    Reference = expense.Sequence,
                    Details = $"{expense.Supplier.Name}",
                    ExchangeRate = expense.ExchangeRate,
                    SellerName = string.Empty
                });
                expense.Payments.Where(x => x.Active == true && x.State == (char)Enums.BillingStates.Paid).ToList().ForEach(payment =>
                {
                    result.Add(new CompanyStateModel()
                    {
                        CompanyOwedAmount = 0,
                        CustomersOwedAmount = 0,
                        IncomeAmount = 0,
                        OutcomeAmount = payment.PaidAmount,
                        CurrencyCode = payment.Currency.Code,
                        CurrencyId = payment.CurrencyId,
                        CurrencyName = payment.Currency.Name,
                        CustomerName = "",
                        Date = payment.Date,
                        Details = $"{expense.Supplier.Name}",
                        ExchangeRate = payment.ExchangeRate,
                        Reference = payment.Sequence,
                        SellerName = string.Empty
                    });
                });
            });


            invoices.ForEach(invoice =>
            {
                result.Add(new CompanyStateModel()
                {
                    CompanyOwedAmount = 0,
                    CustomersOwedAmount = invoice.PatientPaymentAmount,
                    IncomeAmount = 0,
                    OutcomeAmount = invoice.Cost,
                    CurrencyCode = invoice.Currency.Code,
                    CurrencyId = invoice.CurrencyId,
                    CurrencyName = invoice.Currency.Name,
                    CustomerName = invoice.Patient.NameAndCode,
                    Date = invoice.BillingDate.Value,
                    Reference = invoice.InvoiceNumber,
                    Details = $"{invoice.Patient.NameAndCode}",
                    ExchangeRate = invoice.ExchangeRate,
                    SellerName =invoice.Seller==null? string.Empty:invoice.Seller.NameAndCode
                });
                invoice.Payments.Where(x => x.Active == true && x.State == (char)BillingStates.Paid).ToList().ForEach(payment =>
                {
                    result.Add(new CompanyStateModel()
                    {
                        CompanyOwedAmount = 0,
                        CustomersOwedAmount = 0,
                        IncomeAmount = payment.PaidAmount,
                        OutcomeAmount = 0,
                        CurrencyCode = payment.Currency.Code,
                        CurrencyId = payment.CurrencyId,
                        CurrencyName = payment.Currency.Name,
                        CustomerName = "",
                        Date = payment.Date,
                        Details = $"{invoice.Patient.NameAndCode}",
                        ExchangeRate = payment.ExchangeRate,
                        Reference = payment.Sequence,
                        SellerName = payment.Seller == null ? string.Empty : invoice.Seller.NameAndCode
                    });
                });
            });



            return result;
        }

        public async Task<Result<Invoice>> BillQuote(long quoteId)
        {
            var quote = await _Context.Invoices.AsNoTracking().Include(x => x.BranchOffice).Include(x=>x.Appointment).Include(x => x.Currency).Include(x => x.Patient).Include(x => x.Seller)
                 .Include(x => x.TRNControl).Include(x => x.InvoiceDetails).ThenInclude(y => y.Product)
                 .Include(x => x.InvoiceDetails).ThenInclude(y => y.Unit).FirstOrDefaultAsync(x => x.Id == quoteId && x.Active == true && x.State == (char)BillingStates.Quoted);
            if (quote != null)
            {

                quote.InvoiceDetails = quote.InvoiceDetails != null ? quote.InvoiceDetails.Where(d => d.Active == true).ToList() : new List<InvoiceDetail>();
                using (var transaction = await _Context.Database.BeginTransactionAsync())
                {
                    try
                    {
                        var quoteInvoice = new Invoice(quote);
                        quoteInvoice.Id = 0;
                        quoteInvoice.InventoryModified = true;
                        quoteInvoice.InvoiceDetails.ForEach(d => { d.Invoice = null; d.InvoiceId = 0; });
                        quoteInvoice.Payments = null;
                        var addResult = await this.AddWithoutTransaction(quoteInvoice);
                        if (addResult.Status >= 0)
                        {
                            quote.InvoiceDetails = null;
                            quote.Patient = null;
                            quote.BranchOffice = null;
                            quote.Currency = null;
                            quote.Seller = null;
                            quote.TRNControl = null;
                            quote.State = (char)BillingStates.Converted;
                            _Context.Invoices.Update(quote);
                           await _Context.SaveChangesAsync();

                        }
                        else
                        {
                         await   transaction.RollbackAsync();
                            return addResult;
                        }
                       await transaction.CommitAsync();
                    }
                    catch (Exception ex)
                    {
                       await transaction.RollbackAsync();
                        return new Result<Invoice>(-1, -1, ex.Message);
                    }
                }

                return new Result<Invoice>(quoteId, 0, "success_msg");



            }
            else
                return new Result<Invoice>(-1, -1, "error_msg");
        }
    }
}
