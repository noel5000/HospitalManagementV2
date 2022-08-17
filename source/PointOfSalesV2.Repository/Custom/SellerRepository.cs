﻿

namespace PointOfSalesV2.Repository
{
    public class SellerRepository : Repository<Seller>, ISellerRepository
    {
        readonly ISequenceManagerRepository _sequenceRepo;
        public SellerRepository(MainDataContext context, ISequenceManagerRepository sequenceRepo) : base(context)
        {
            this._sequenceRepo = sequenceRepo;
        }

        public override async Task<Result<Seller>> AddAsync(Seller entity)
        {
            using (var transaction = await this._Context.Database.BeginTransactionAsync())
            {
                try
                {
                    entity.Code = await _sequenceRepo.CreateSequence(Common.Enums.SequenceTypes.Sellers);
                    var result = await base.AddAsync(entity);
                    if (result.Status < 0) 
                    {
                      await  transaction.RollbackAsync();
                    }
                    else
                        await transaction.CommitAsync();


                    return result;
                }
                catch (Exception ex) 
                {
                  await  transaction.RollbackAsync();
                    return new Result<Seller>(-1,-1,"error_msg",null,ex);
                }
               
            }
           
        
        }

        public async Task<ComissionsReport> PaymentsComissions(ComissionsSearch search)
        {
            var result = new ComissionsReport() { ComissionsByCyrrencies = new List<ComissionsByCurrency>() };
            var invoices = (await _Context.CustomersPayments.AsNoTracking().Include(x => x.Currency).Include(x => x.Seller).Include(x=>x.Customer)
                .Where(x => 
                x.Active == true && x.State!=(char)BillingStates.Nulled &&
                (search.CustomerId.HasValue && search.CustomerId.Value>0?x.CustomerId== search.CustomerId.Value:x.CustomerId>0) &&
                (search.CurrencyId.HasValue && search.CurrencyId.Value > 0 ? x.CurrencyId == search.CurrencyId.Value : x.CurrencyId > 0) &&
                (search.SellerId.HasValue && search.SellerId.Value > 0 ? x.SellerId == search.SellerId.Value : x.SellerId > 0) &&
                (search.InitialDate.HasValue ? x.Date >= search.InitialDate.Value : x.Date > DateTime.MinValue) &&
                (search.FinalDate.HasValue  ? x.Date <= search.FinalDate.Value : x.Date < DateTime.Now) &&
                (string.IsNullOrEmpty(search.InvoiceNumber)?x.InvoiceNumber!="":x.InvoiceNumber.ToUpper()== search.InvoiceNumber.ToUpper())
                && x.SellerRate>0
                ).ToListAsync()).GroupBy(x => x.CurrencyId).ToList();

            invoices.ForEach(r => {
                result.ComissionsByCyrrencies.Add(new ComissionsByCurrency()
                {
                    TotalAmount = r.Sum(x => x.SellerRate),
                    CurrencyCode = r.FirstOrDefault().Currency.Code,
                    CurrencyName = r.FirstOrDefault().Currency.Name,
                    Details =r.Select(x => new ComissionDetail() 
                    {
                    Amount=x.SellerRate,
                    BeforeTaxesAmount=0,
                    PaidAmount=x.PaidAmount,
                    TotalAmount=x.TotalAmount,
                    CurrencyCode=x.Currency.Code,
                    CustomerName=x.Customer.NameAndCode,
                    Date=x.Date,
                    Reference=x.Sequence,
                    SellerName=x.Seller?.NameAndCode??""
                    }).ToList()
                });
            });


            return result;
        }

        public async Task<ComissionsReport> SalesComissions(ComissionsSearch search)
        {
            var result = new ComissionsReport() { ComissionsByCyrrencies = new List<ComissionsByCurrency>() };
            var invoices =(await _Context.Invoices.AsNoTracking().Include(x => x.Currency).Include(x => x.Seller).Include(x => x.Patient)
                .Where(x =>
                x.Active == true && (x.State == (char)BillingStates.Billed || x.State == (char)BillingStates.Paid || x.State == (char)BillingStates.FullPaid) &&
                (search.CustomerId.HasValue && search.CustomerId.Value > 0 ? x.CustomerId == search.CustomerId.Value : x.CustomerId > 0) &&
                (search.CurrencyId.HasValue && search.CurrencyId.Value > 0 ? x.CurrencyId == search.CurrencyId.Value : x.CurrencyId > 0) &&
                (search.SellerId.HasValue && search.SellerId.Value > 0 ? x.SellerId == search.SellerId.Value : x.SellerId > 0) &&
                (search.InitialDate.HasValue ? x.BillingDate >= search.InitialDate.Value : x.BillingDate > DateTime.MinValue) &&
                (search.FinalDate.HasValue ? x.BillingDate <= search.FinalDate.Value : x.BillingDate < DateTime.Now) &&
                (string.IsNullOrEmpty(search.InvoiceNumber) ? x.InvoiceNumber != "" : x.InvoiceNumber.ToUpper() == search.InvoiceNumber.ToUpper())
                && x.SellerRate > 0
                ).ToListAsync()).GroupBy(x => x.CurrencyId).ToList();

            invoices.ForEach(r => {
                result.ComissionsByCyrrencies.Add(new ComissionsByCurrency()
                {
                    TotalAmount = r.Sum(x => x.SellerRate),
                    CurrencyCode = r.FirstOrDefault().Currency.Code,
                    CurrencyName = r.FirstOrDefault().Currency.Name,
                    Details = r.Select(x => new ComissionDetail()
                    {
                        Amount = x.SellerRate,
                        BeforeTaxesAmount = x.BeforeTaxesAmount,
                        PaidAmount = x.PaidAmount,
                        TotalAmount = x.TotalAmount,
                        CurrencyCode = x.Currency.Code,
                        CustomerName = x.Patient.NameAndCode,
                        Date = x.BillingDate.Value,
                        Reference = x.InvoiceNumber,
                        SellerName = x.Seller?.NameAndCode ?? ""
                    }).ToList()
                });
            });


            return result;
        }

        public override async Task<Result<Seller>> UpdateAsync(Seller entity, bool fromDb = true)
        {
            entity.Code = string.IsNullOrEmpty(entity.Code) ? await _sequenceRepo.CreateSequence(Common.Enums.SequenceTypes.Sellers) : entity.Code;
            return await base.UpdateAsync(entity);
        }

    }
}
