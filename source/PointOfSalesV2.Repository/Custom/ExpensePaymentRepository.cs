﻿

namespace PointOfSalesV2.Repository
{
    public class ExpensesPaymentRepository : Repository<ExpensesPayment>, IExpensesPaymentRepository
    {
        readonly ISequenceManagerRepository _sequenceRepo;
        public ExpensesPaymentRepository(MainDataContext context, ISequenceManagerRepository sequenceManagerRepository) : base(context)
        {
            this._sequenceRepo = sequenceManagerRepository;
        }



        public override async Task<Result<ExpensesPayment>> AddAsync(ExpensesPayment entity)
        {
            throw new NotImplementedException();
        }

        public override async Task<Result<ExpensesPayment>> UpdateAsync(ExpensesPayment entity, bool fromDb = true)
        {
            return new Result<ExpensesPayment>(-1, -1, "cannotUpdatePayment_msg");
        }

        public override async Task<Result<ExpensesPayment>> RemoveAsync(long id)
        {
            Result<ExpensesPayment> result = new Result<ExpensesPayment>(-1, -1, "");

            using (var trans = await _Context.Database.BeginTransactionAsync())
            {
                var entity = await _Context.ExpensesPayments.FindAsync(id);
                _Context.Entry<ExpensesPayment>(entity).State = EntityState.Detached;

                if (entity == null)
                {
                    await trans.RollbackAsync();
                    return new Result<ExpensesPayment>(-1, -1, "CannotDeleteExpense_msg");
                }

                try
                {
                    var expense = await _Context.Expenses.FindAsync(entity.ExpenseId);
                    _Context.Entry<Expense>(expense).State = EntityState.Detached;

                    var payment = await _Context.CompanyPayments.FindAsync(entity.PaymentId);
                    _Context.Entry<CompanyPayments>(payment).State = EntityState.Detached;

                    if (expense.State != (char)Enums.BillingStates.Paid && expense.State != (char)Enums.BillingStates.FullPaid)
                    {
                        await trans.RollbackAsync();
                        return new Result<ExpensesPayment>(-1, -1, "CannotDeleteExpense_msg");
                    }
                  
                    entity.State = (char)Enums.BillingStates.Nulled;
                    payment.State = (char)Enums.BillingStates.Nulled;
                    expense.OwedAmount += entity.PaidAmount;
                    expense.OwedAmount = expense.OwedAmount > expense.TotalAmount ? expense.TotalAmount : expense.OwedAmount;

                    expense.PaidAmount -= entity.PaidAmount;
                    expense.PaidAmount = expense.PaidAmount <= 0 ? 0 : expense.PaidAmount;
                    expense.State = expense.PaidAmount <= 0 && expense.State == (char)Enums.BillingStates.Paid ? (char)Enums.BillingStates.Billed : expense.State;
                    _Context.ExpensesPayments.Update(entity);
                    await _Context.SaveChangesAsync();
                    _Context.CompanyPayments.Update(payment);
                    await _Context.SaveChangesAsync();
                    _Context.Expenses.Update(expense);
                    await _Context.SaveChangesAsync();
                    await trans.CommitAsync();
                    result = new Result<ExpensesPayment>(entity.Id, 0, "ok_msg", new List<ExpensesPayment>() { entity });
                }
                catch (Exception ex)
                {
                    await trans.RollbackAsync();
                    result = new Result<ExpensesPayment>(-1, -1, "error_msg", null, new Exception(ex.Message));
                }
            }

            return result;
        }

        public async Task<Result<Payment>> AddPayment(CompanyPayments payment, List<Expense> expenses)
        {
            Result<Payment> result = new Result<Payment>(-1, -1, "");

            using (var trans = await _Context.Database.BeginTransactionAsync())
            {
                var currentDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                try
                {
                    var currency = await _Context.Currencies.FindAsync(payment.CurrencyId);
                    _Context.Entry<Currency>(currency).State = EntityState.Detached;
                    var paymentEntity = new CompanyPayments()
                    {
                        PaidAmount = payment.PaidAmount,
                        TotalAmount = payment.TotalAmount,
                        PaymentDestinationId = payment.PaymentDestinationId,
                        GivenAmount = payment.GivenAmount,
                        Date = DateTime.Now,
                        Active = true,
                        CurrencyId = payment.CurrencyId,
                        ExchangeRate = currency.ExchangeRate,
                        OutstandingAmount = payment.OutstandingAmount,
                        ExchangeRateAmount = payment.PaidAmount * currency.ExchangeRate,
                        DestinationType = (byte)Enums.CompanyPaymentTypes.ExpensePayment,
                        Details = payment.Details,
                        Reference = payment.Reference,
                        Sequence = await _sequenceRepo.CreateSequence(Enums.SequenceTypes.CompanyPayments),
                        PaymentTypeId = payment.PaymentTypeId,
                        State = (char)Enums.BillingStates.Paid,
                        PositiveBalance = payment.GivenAmount - payment.PaidAmount,
                    };
                    _Context.CompanyPayments.Add(paymentEntity);
                    await _Context.SaveChangesAsync();

                    var expensePaymentSeq = await _Context.SequencesControl.AsNoTracking().FirstOrDefaultAsync(x => x.Active == true && x.Code == (short)Enums.SequenceTypes.ExpensePayments);
                    expenses.ForEach(e =>
                    {
                        string sequence = String.Format("{0}{1:00000}", ((SequenceTypeCode)(short)expensePaymentSeq.Code).ToString(), (expensePaymentSeq.NumericControl + 1));
                        expensePaymentSeq.NumericControl += 1;

                        ExpensesPayment expensesPayment = new ExpensesPayment()
                        {
                            ExchangeRateAmount = currency.ExchangeRate * e.CurrentPaidAmount,
                            GivenAmount = payment.GivenAmount,
                            Sequence = sequence,
                            OutstandingAmount = e.OwedAmount - e.CurrentPaidAmount,
                            CurrentOutstandingAmount = e.OwedAmount - e.CurrentPaidAmount,
                            PaidAmount = e.CurrentPaidAmount,
                            TotalAmount = e.TotalAmount,
                            Active = true,
                            ExchangeRate = currency.ExchangeRate,
                            CurrencyId = currency.Id,
                            Date = paymentEntity.Date,
                            Details = payment.Details,
                            ExpenseCurrencyId = e.CurrencyId,
                            ExpenseId = e.Id,
                            ExpenseReference = e.Sequence,
                            PaymentSequence = paymentEntity.Sequence,
                            PaymentId = paymentEntity.Id,
                            PaymentTypeId = payment.PaymentTypeId,
                            PositiveBalance = e.OwedAmount - e.CurrentPaidAmount,
                            State = (char)Enums.BillingStates.Paid,
                            SupplierId = e.SupplierId
                        };
                        _Context.ExpensesPayments.Add(expensesPayment);
                        _Context.SaveChanges();

                        e.State = (char)Enums.BillingStates.Paid;
                        e.PaidAmount += expensesPayment.PaidAmount;
                        e.PaidAmount = e.PaidAmount > e.TotalAmount ? e.TotalAmount : e.PaidAmount;
                        e.OwedAmount -= expensesPayment.PaidAmount;
                        e.OwedAmount = e.OwedAmount < 0 ? 0 : e.OwedAmount;
                        e.CurrentPaidAmount = e.PaidAmount;
                        e.Currency = null;
                        e.Supplier = null;
                        e.BranchOffice = null;
                        e.Payments = null;
                        e.PaymentType = null;
                        e.Taxes = null;
                        _Context.Expenses.Update(e);
                        _Context.SaveChanges();
                    });
                    _Context.SequencesControl.Update(expensePaymentSeq);
                    await _Context.SaveChangesAsync();
                    await trans.CommitAsync();
                    result = new Result<Payment>(0, (int)paymentEntity.Id, "ok_msg");
                }
                catch (Exception ex)
                {
                    await trans.RollbackAsync();
                    result = new Result<Payment>(-1, -1, "error_msg", null, new Exception(ex.Message));
                }
            }

            return result;
        }

        public Result<Payment> AddPaymentWithoutTransaction(CompanyPayments payment,Expense expenses, SequenceControl expenseSeqControl)
        {
            Result<Payment> result = new Result<Payment>(-1, -1, "");


            var currentDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            try
            {
                var currency = _Context.Currencies.AsNoTracking().FirstOrDefault(x=>x.Id==payment.CurrencyId);
                var paymentSeq = _Context.SequencesControl.AsNoTracking().FirstOrDefault(x => x.Active == true && x.Code == (short)Enums.SequenceTypes.CompanyPayments);
                string paymentSeqString = String.Format("{0}{1:00000}", ((SequenceTypeCode)(short)paymentSeq.Code).ToString(), (paymentSeq.NumericControl + 1));
                paymentSeq.NumericControl += 1;
                var paymentEntity = new CompanyPayments()
                {
                    PaidAmount = payment.PaidAmount,
                    TotalAmount = payment.TotalAmount,
                    PaymentDestinationId = payment.PaymentDestinationId,
                    GivenAmount = payment.GivenAmount,
                    Date = DateTime.Now,
                    Active = true,
                    CurrencyId = payment.CurrencyId,
                    ExchangeRate = currency.ExchangeRate,
                    OutstandingAmount = payment.OutstandingAmount,
                    ExchangeRateAmount = payment.PaidAmount * currency.ExchangeRate,
                    DestinationType = (byte)Enums.CompanyPaymentTypes.ExpensePayment,
                    Details = payment.Details,
                    Reference = payment.Reference,
                    Sequence = paymentSeqString,
                    PaymentTypeId = payment.PaymentTypeId,
                    State = (char)Enums.BillingStates.Paid,
                    PositiveBalance = payment.GivenAmount - payment.PaidAmount,
                };
                _Context.CompanyPayments.Add(paymentEntity);
                _Context.SaveChanges();

                var expensePaymentSeq = _Context.SequencesControl.AsNoTracking().FirstOrDefault(x => x.Active == true && x.Code == (short)Enums.SequenceTypes.ExpensePayments);


                expenses.PaidAmount = expenses.PaidAmount > expenses.TotalAmount ? expenses.TotalAmount : expenses.PaidAmount;

                expenses.OwedAmount = expenses.OwedAmount < 0 ? 0 : expenses.OwedAmount;
                expenses.CurrentPaidAmount = expenses.PaidAmount;
                expenses.Currency = null;
                expenses.Supplier = null;
                expenses.BranchOffice = null;
                expenses.Payments = null;
                expenses.PaymentType = null;
                expenses.Taxes = null;
                    _Context.Expenses.Add(expenses);
                    _Context.SaveChanges();
                    string sequence = String.Format("{0}{1:00000}", ((SequenceTypeCode)(short)expensePaymentSeq.Code).ToString(), (expensePaymentSeq.NumericControl + 1));
                    expensePaymentSeq.NumericControl += 1;

                    ExpensesPayment expensesPayment = new ExpensesPayment()
                    {
                        ExchangeRateAmount = currency.ExchangeRate * expenses.CurrentPaidAmount,
                        GivenAmount = payment.GivenAmount,
                        Sequence = sequence,
                        OutstandingAmount = expenses.OwedAmount,
                        CurrentOutstandingAmount = expenses.OwedAmount,
                        PaidAmount = expenses.CurrentPaidAmount,
                        TotalAmount = expenses.TotalAmount,
                        Active = true,
                        ExchangeRate = currency.ExchangeRate,
                        CurrencyId = currency.Id,
                        Date = paymentEntity.Date,
                        Details = payment.Details,
                        ExpenseCurrencyId = expenses.CurrencyId,
                        ExpenseId = expenses.Id,
                        ExpenseReference = expenses.Sequence,
                        PaymentSequence = paymentEntity.Sequence,
                        PaymentId = paymentEntity.Id,
                        PaymentTypeId = payment.PaymentTypeId,
                        PositiveBalance = expenses.OwedAmount,
                        State = (char)Enums.BillingStates.Paid,
                        SupplierId = expenses.SupplierId
                    };
                    _Context.ExpensesPayments.Add(expensesPayment);
                    _Context.SaveChanges();

                    
             
                _Context.SequencesControl.UpdateRange(expensePaymentSeq, paymentSeq, expenseSeqControl);
                _Context.SaveChanges();

                result = new Result<Payment>(0, (int)paymentEntity.Id, "ok_msg");
            }
            catch (Exception ex)
            {
                result = new Result<Payment>(-1, -1, "error_msg",null,ex);
                return result;
            }


            return result;
        }
    }
}
