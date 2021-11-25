using Microsoft.EntityFrameworkCore;
using PointOfSalesV2.Common;
using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; using System.Threading.Tasks;
using static PointOfSalesV2.Common.Enums;

namespace PointOfSalesV2.Repository
{
    public class ExpenseRepository : Repository<Expense>, IExpenseRepository
    {
        readonly ISequenceManagerRepository _sequenceRepo;
        readonly IExpensesPaymentRepository _expensePayments;
        public ExpenseRepository(MainDataContext context, ISequenceManagerRepository sequenceManagerRepository, IExpensesPaymentRepository expensePayments) : base(context)
        {
            this._sequenceRepo = sequenceManagerRepository;
            this._expensePayments = expensePayments;
        }

        public async  Task<IEnumerable<Expense>> GetDebsToPay(DateTime? startDate, DateTime? endDate, long? supplierId, long? currencyId, long? branchOfficeId)
        {
           
            return await _Context.Expenses.Include(x=>x.BranchOffice).Include(x=>x.Currency).Include(x=>x.Supplier).Where(
                expense => expense.Active == true && expense.OwedAmount > 0 && expense.State != (char)Enums.BillingStates.Nulled && expense.State != (char)Enums.BillingStates.FullPaid
            && (startDate.HasValue ? expense.Date >= startDate.Value : expense.Id > 0) &&
            (endDate.HasValue ? expense.Date <= endDate.Value : expense.Id > 0) && (supplierId.HasValue && supplierId.Value > 0 ? expense.SupplierId == supplierId.Value : expense.Id > 0) &&
            (currencyId.HasValue && currencyId.Value > 0 ? expense.CurrencyId == currencyId.Value : expense.Id > 0) && (branchOfficeId.HasValue && branchOfficeId.Value > 0 ? expense.BranchOfficeId == branchOfficeId.Value : expense.Id > 0)
                ).ToListAsync();
        }

        public override async Task< Result<Expense>> AddAsync(Expense entity)
        {
            Result<Expense> result = new Result<Expense>(-1, -1, "");

            using (var trans = await _Context.Database.BeginTransactionAsync())
            {
                var currentDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                try
                {
                    var expenseSeq = _Context.SequencesControl.AsNoTracking().FirstOrDefault(x => x.Active == true && x.Code == (short)Enums.SequenceTypes.Expenses);
                    string expenseSeqString = String.Format("{0}{1:00000}", ((SequenceTypeCode)(short)expenseSeq.Code).ToString(), (expenseSeq.NumericControl + 1));
                    expenseSeq.NumericControl += 1;
                    entity.Sequence = expenseSeqString;
                    entity.ExpenseReference = entity.ExpenseReference ?? "";
                    var taxes = entity.Taxes?.ToList();
                    entity.Currency = entity.Currency ?? await _Context.Currencies.FindAsync(entity.CurrencyId);
                    _Context.Entry<Currency>(entity.Currency).State = EntityState.Detached;
                    var currency = entity.Currency;
                    taxes.ForEach(d =>
                    {
                        d.Id = 0;
                        d.Active = true;
                        d.Date = entity.Date;
                        d.CurrencyId = entity.CurrencyId;
                        d.Currency = entity.Currency;
                        d.Expense = null;
                        d.TRN = entity.TRN;
                        d.Reference = entity.Sequence;
                        d.Tax = d.Tax ?? _Context.Taxes.Find(d.TaxId);
                        _Context.Entry<Tax>(d.Tax).State = EntityState.Detached;
                        d.TaxAmount = d.Tax.Rate * entity.BeforeTaxesAmount;
                        d.ExchangeRateAmount = (d.Currency.ExchangeRate * d.TaxAmount);
                        d.Currency = null;
                        d.Tax = null;
                    });
                    entity.Active = true;
                    entity.BranchOffice = null;
                    entity.PaymentType = null;
                    entity.TotalAmount = entity.BeforeTaxesAmount + taxes.Sum(x => x.TaxAmount);
                    entity.PaidAmount = entity.PaymentTypeId.HasValue ? (entity.GivenAmount >= entity.TotalAmount ? entity.TotalAmount : entity.GivenAmount) : 0;
                    entity.ReturnedAmount = entity.PaymentTypeId.HasValue ? (entity.GivenAmount > entity.TotalAmount ? entity.GivenAmount - entity.TotalAmount : 0) : 0;
                    entity.Supplier = null;
                    entity.TaxesAmount = taxes.Sum(d => d.TaxAmount);
                    entity.Taxes = null;
                    entity.State = entity.PaidAmount > 0 ? (char)Enums.BillingStates.Paid : (char)Enums.BillingStates.Billed;
                    entity.OwedAmount = entity.TotalAmount - entity.PaidAmount;
                    entity.ExchangeRateAmount = entity.Currency.ExchangeRate * entity.TotalAmount;
                    entity.ExchangeRate = entity.Currency.ExchangeRate;
                    entity.Currency = null;

                    if (entity.PaymentTypeId.HasValue && entity.PaidAmount > 0)
                    {
                        var payment = new CompanyPayments()
                        {
                            PaidAmount = entity.PaidAmount,
                            TotalAmount = entity.TotalAmount,
                            GivenAmount = entity.GivenAmount,
                            PaymentDestinationId = entity.SupplierId,
                            Date = DateTime.Now,
                            Active = true,
                            CurrencyId = entity.CurrencyId,
                            ExchangeRate = currency.ExchangeRate,
                            OutstandingAmount = entity.OwedAmount,
                            ExchangeRateAmount = entity.PaidAmount * currency.ExchangeRate,
                            DestinationType = (byte)Enums.CompanyPaymentTypes.ExpensePayment,
                            Details = entity.Details,
                            Reference = entity.ExpenseReference,
                            PaymentTypeId = entity.PaymentTypeId.Value,
                            State = entity.State,
                            PositiveBalance = entity.GivenAmount - entity.PaidAmount,


                        };
                        entity.Currency = null;
                        entity.BranchOffice = null;
                        entity.PaymentType = null;
                        entity.Payments = null;
                        entity.Supplier = null;
                        entity.Taxes = null;

                        var paymentResult = _expensePayments.AddPaymentWithoutTransaction(payment,  entity , expenseSeq);
                        if (paymentResult.Status < 0)
                        {
                            await trans.RollbackAsync();
                            return new Result<Expense>(-1, -1, paymentResult.Message, null, paymentResult.Exception);
                        }

                        //_Context.Expenses.Add(entity);
                        //await _Context.SaveChangesAsync();
                    }
                    else
                    {
                        _Context.SequencesControl.Update(expenseSeq);
                     await   _Context.SaveChangesAsync();

                        _Context.Expenses.Add(entity);
                        await _Context.SaveChangesAsync();
                    }

                    taxes.ForEach(x => { x.ExpenseId = entity.Id; });
                    _Context.ExpenseTaxes.AddRange(taxes);
                    await _Context.SaveChangesAsync();

                    await trans.CommitAsync();
                    result = new Result<Expense>(entity.Id, 0, "ok_msg", new List<Expense>() { entity });
                }
                catch (Exception ex)
                {
                    await trans.RollbackAsync();
                    result = new Result<Expense>(-1, -1, "error_msg", null, new Exception(ex.Message));
                }
            }

            return result;
        }

        public override async Task< Result<Expense>> UpdateAsync(Expense entity, bool fromDb = true)
        {
            Result<Expense> result = new Result<Expense>(-1, -1, "");

            using (var trans = await _Context.Database.BeginTransactionAsync())
            {
                var oldValue = await _Context.Expenses.FindAsync(entity.Id);
                _Context.Entry<Expense>(oldValue).State = EntityState.Detached;
                if ((entity.PaymentTypeId.HasValue && entity.PaidAmount > 0) || oldValue == null || oldValue.State != (char)Enums.BillingStates.Billed || _Context.ExpensesPayments.AsNoTracking().Count(x => x.Active == true && x.State == (char)Enums.BillingStates.Paid && x.ExpenseId == entity.Id) > 0)
                {
                    await trans.RollbackAsync();
                    return new Result<Expense>(-1, -1, "CannotUpdateExpense_msg");
                }
                var currentDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                try
                {
                    entity.Active = true;
                    entity.ExpenseReference = entity.ExpenseReference ?? "";
                    entity.Date = DateTime.MinValue == entity.Date ? currentDate : entity.Date;
                    var taxes = entity.Taxes?.ToList();
                    entity.Currency = entity.Currency ?? await _Context.Currencies.FindAsync(entity.CurrencyId);
                    _Context.Entry<Currency>(entity.Currency).State = EntityState.Detached;
                    var currency = entity.Currency;
                    var oldTaxes = await _Context.ExpenseTaxes.AsNoTracking().Where(x => x.Active == true && x.ExpenseId == entity.Id).ToListAsync();
                    //oldTaxes.ForEach(o => {
                    //    if (!taxes.Any(x => x.Id == o.Id)) 
                    //    {
                    //        _Context.ExpenseTaxes.Remove(o);
                    //        _Context.SaveChanges();
                    //    }
                    //});

                    _Context.ExpenseTaxes.RemoveRange(oldTaxes.Where(x => !taxes.Any(y => y.Id == x.Id)));
                    await _Context.SaveChangesAsync();
                    taxes.ForEach(d =>
                    {
                        d.Date = entity.Date;
                        d.CurrencyId = entity.CurrencyId;
                        d.Currency = entity.Currency;
                        d.Expense = null;
                        d.TRN = entity.TRN;
                        d.Active = true;
                        d.Reference = entity.Sequence;
                        d.Tax = d.Tax ?? _Context.Taxes.Find(d.TaxId);
                        _Context.Entry<Tax>(d.Tax).State = EntityState.Detached;
                        d.TaxAmount = d.Tax.Rate * entity.BeforeTaxesAmount;
                        d.ExchangeRateAmount = (d.Currency.ExchangeRate * d.TaxAmount);
                        d.Currency = null;
                        d.Tax = null;
                        if (d.Id == 0)
                            _Context.ExpenseTaxes.Add(d);
                        else
                            _Context.ExpenseTaxes.Update(d);

                        _Context.SaveChanges();
                    });
                    entity.BranchOffice = null;
                    entity.PaymentType = null;
                    entity.TotalAmount = entity.BeforeTaxesAmount + taxes.Sum(x => x.TaxAmount);
                    entity.PaidAmount = entity.PaymentTypeId.HasValue ? (entity.GivenAmount >= entity.TotalAmount ? entity.TotalAmount : entity.GivenAmount) : 0;
                    entity.ReturnedAmount = entity.PaymentTypeId.HasValue ? (entity.GivenAmount > entity.TotalAmount ? entity.GivenAmount - entity.TotalAmount : 0) : 0;
                    entity.Supplier = null;
                    entity.Taxes = null;
                    entity.TaxesAmount = taxes.Sum(x => x.TaxAmount);
                    entity.State = entity.PaidAmount > 0 ? (char)Enums.BillingStates.Paid : (char)Enums.BillingStates.Billed;
                    entity.OwedAmount = entity.TotalAmount - entity.PaidAmount;
                    entity.ExchangeRateAmount = entity.Currency.ExchangeRate * entity.TotalAmount;
                    entity.Currency = null;
                    _Context.Expenses.Update(entity);
                    await _Context.SaveChangesAsync();
                   

                    await trans.CommitAsync();
                    result = new Result<Expense>(entity.Id, 0, "ok_msg", new List<Expense>() { entity });
                }
                catch (Exception ex)
                {
                    await trans.RollbackAsync();
                    result = new Result<Expense>(-1, -1, "error_msg", null, new Exception(ex.Message));
                }
            }

            return result;
        }

        public override async Task< Result<Expense>> RemoveAsync(long id)
        {
            Result<Expense> result = new Result<Expense>(-1, -1, "");

            using (var trans = await _Context.Database.BeginTransactionAsync())
            {
                var entity = await _Context.Expenses.FindAsync(id);
                _Context.Entry<Expense>(entity).State = EntityState.Detached;

                if (entity == null || entity.State != (char)Enums.BillingStates.Billed || _Context.ExpensesPayments.AsNoTracking().Count(x => x.Active == true && x.State != (char)Enums.BillingStates.Paid && x.ExpenseId == id) > 0)
                {
                    await trans.RollbackAsync();
                    return new Result<Expense>(-1, -1, "CannotDeleteExpense_msg");
                }

                try
                {
                    entity.State = (char)Enums.BillingStates.Nulled;
                    _Context.Expenses.Update(entity);
                    await _Context.SaveChangesAsync();

                    await trans.CommitAsync();
                    result = new Result<Expense>(entity.Id, 0, "ok_msg", new List<Expense>() { entity });
                }
                catch (Exception ex)
                {
                    await trans.RollbackAsync();
                    result = new Result<Expense>(-1, -1, "error_msg", null, new Exception(ex.Message));
                }
            }

            return result;
        }
    }
}
