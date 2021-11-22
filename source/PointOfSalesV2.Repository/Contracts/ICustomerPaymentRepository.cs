using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text; using System.Threading.Tasks;
using System.Threading.Tasks;

namespace PointOfSalesV2.Repository
{
    public interface ICustomerPaymentRepository: IBase<CustomerPayment>
    {
        Task<CustomerPayment> ApplyInvoicePayment(CustomerPayment payment);
        public Task<List<CustomerPayment>> IncomesReport(long branchOfficeId, long customerId, long currencyId, long paymentTypeId, DateTime? initialDate, DateTime? endDate);
        public Task<object> CommisionsReport(object searchParams);

        Task<Result<object>> PayInvoices(InvoicesPaymentModel model);
        Task<Result<object>> ReversePayment(string sequence, string userId);
    }
}
