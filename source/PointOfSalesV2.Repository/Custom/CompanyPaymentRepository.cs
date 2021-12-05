

global using PointOfSalesV2.Common;

namespace PointOfSalesV2.Repository
{
    public class CompanyPaymentRepository : Repository<CompanyPayments>, ICompanyPaymentRepository
    {
        readonly ISequenceManagerRepository _sequenceRepo;
        public CompanyPaymentRepository(MainDataContext context, ISequenceManagerRepository sequenceManagerRepository) : base(context)
        {
            this._sequenceRepo = sequenceManagerRepository;
        }



        public override async Task<Result<CompanyPayments>> AddAsync(CompanyPayments entity)
        {

            Result<CompanyPayments> result = new Result<CompanyPayments>(-1, -1, "error_msg");

            using (var trans = await _Context.Database.BeginTransactionAsync())
            {
                var currentDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                try
                {
                    var currency = await _Context.Currencies.FindAsync(entity.CurrencyId);
                    _Context.Entry<Currency>(currency).State = EntityState.Detached;
                    var paymentEntity = new CompanyPayments()
                    {
                        PaidAmount = entity.PaidAmount,
                        TotalAmount = entity.TotalAmount,
                        PaymentDestinationId = entity.PaymentDestinationId,
                        GivenAmount = entity.GivenAmount,
                        Date = DateTime.Now,
                        CurrencyId = entity.CurrencyId,
                        ExchangeRate = currency.ExchangeRate,
                        OutstandingAmount = entity.OutstandingAmount,
                        ExchangeRateAmount = entity.PaidAmount * currency.ExchangeRate,
                        DestinationType = entity.DestinationType,
                        Details = entity.Details,
                        Reference = entity.Reference,
                        Sequence = await _sequenceRepo.CreateSequence(Enums.SequenceTypes.CompanyPayments),
                        PaymentTypeId = entity.PaymentTypeId,
                        State = (char)Enums.BillingStates.Paid,
                        PositiveBalance = entity.GivenAmount - entity.PaidAmount,
                    };
                    _Context.CompanyPayments.Add(paymentEntity);
                    await _Context.SaveChangesAsync();
                    await trans.CommitAsync();
                    result = new Result<CompanyPayments>(0, (int)paymentEntity.Id, "ok_msg");
                }
                catch (Exception ex)
                {
                    await trans.RollbackAsync();
                    result = new Result<CompanyPayments>(-1, -1, "error_msg", null, new Exception(ex.Message));
                }
            }

            return result;
           
        }

        public override async Task<Result<CompanyPayments>> UpdateAsync(CompanyPayments entity, bool fromDb = true)
        {
            Result<CompanyPayments> result = new Result<CompanyPayments>(-1, -1, "error_msg");

            using (var trans = await _Context.Database.BeginTransactionAsync())
            {
                var currentDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                try
                {
                    var currency = await _Context.Currencies.FindAsync(entity.CurrencyId);
                    _Context.Entry<Currency>(currency).State = EntityState.Detached;
                    var paymentEntity = new CompanyPayments()
                    {
                        Id=entity.Id,
                        PaidAmount = entity.PaidAmount,
                        TotalAmount = entity.TotalAmount,
                        PaymentDestinationId = entity.PaymentDestinationId,
                        GivenAmount = entity.GivenAmount,
                        Date = DateTime.Now,
                        CurrencyId = entity.CurrencyId,
                        ExchangeRate = currency.ExchangeRate,
                        OutstandingAmount = entity.OutstandingAmount,
                        ExchangeRateAmount = entity.PaidAmount * currency.ExchangeRate,
                        DestinationType = entity.DestinationType,
                        Details = entity.Details,
                        Reference = entity.Reference,
                        PaymentTypeId = entity.PaymentTypeId,
                        State = (char)Enums.BillingStates.Paid,
                        PositiveBalance = entity.GivenAmount - entity.PaidAmount,
                    };
                    _Context.CompanyPayments.Update(paymentEntity);
                    await _Context.SaveChangesAsync();
                    await trans.CommitAsync();
                    result = new Result<CompanyPayments>(0, (int)paymentEntity.Id, "ok_msg");
                }
                catch (Exception ex)
                {
                  await  trans.RollbackAsync();
                    result = new Result<CompanyPayments>(-1, -1, "error_msg", null, new Exception(ex.Message));
                }
            }

            return result;
        }

        public override async Task<Result<CompanyPayments>> RemoveAsync(long id)
        {
            Result<CompanyPayments> result = new Result<CompanyPayments>(-1, -1, "error_msg");

            var payment = await _Context.CompanyPayments.FindAsync(id);
            _Context.Entry<CompanyPayments>(payment).State = EntityState.Detached;
            IEnumerable<ICommonData> children = null;

            switch (payment.DestinationType) 
            {
                case (byte)Enums.CompanyPaymentTypes.ExpensePayment:
                    children = _Context.ExpensesPayments.AsNoTracking().Where(x => x.PaymentId == id && x.Active == true && x.State != (char)Enums.BillingStates.Nulled);
                    break;
                case (byte)Enums.CompanyPaymentTypes.CustomerPayment:
                    throw new NotImplementedException();
                    break;
            }
            if (children !=null && children.Count() > 0) 
            {
                return result;
            }
            payment.State = (char)Enums.BillingStates.Nulled;
            _Context.CompanyPayments.Update(payment);
         await   _Context.SaveChangesAsync();

            return result;
        }

     
    }
}
