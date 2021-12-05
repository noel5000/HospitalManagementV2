

namespace PointOfSalesV2.Repository
{
    public interface ISellerRepository : IBase<Seller>
    {
        Task<ComissionsReport> SalesComissions(ComissionsSearch search);
      Task<ComissionsReport> PaymentsComissions(ComissionsSearch search);
    }
}
