using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text; using System.Threading.Tasks;
using System.Threading.Tasks;

namespace PointOfSalesV2.Repository
{
    public interface IBusinessStateRepository 
    {
        Task<List<object>> GetFinancialState(DateTime? startDate, DateTime? endDate);

       Task< List<TaxesReport>> GetTaxesReport(DateTime? startDate, DateTime? endDate);
    }
}
