using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text; using System.Threading.Tasks;

namespace PointOfSalesV2.Repository
{

    public interface IUnitOfWork
    {
        IDbContextTransaction CreateTransaction();

        int SaveChanges();
        Task<int> SaveChangesAsync();
    }
}
