using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text; using System.Threading.Tasks;

namespace PointOfSalesV2.Repository
{
    public interface ISellerRepository : IBase<Seller>
    {
        Task<ComissionsReport> SalesComissions(ComissionsSearch search);
      Task<ComissionsReport> PaymentsComissions(ComissionsSearch search);
    }
}
