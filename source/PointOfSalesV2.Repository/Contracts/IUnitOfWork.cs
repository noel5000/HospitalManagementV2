using Microsoft.EntityFrameworkCore.Storage;


namespace PointOfSalesV2.Repository
{

    public interface IUnitOfWork
    {
        IDbContextTransaction CreateTransaction();

        int SaveChanges();
        Task<int> SaveChangesAsync();
    }
}
