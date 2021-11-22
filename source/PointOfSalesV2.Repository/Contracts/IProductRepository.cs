using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text; using System.Threading.Tasks;

namespace PointOfSalesV2.Repository
{
    public interface IProductRepository : IBase<Product>
    {
        Task<IEnumerable<Product>> GetProductsOnlyFilteredAndLimited(int pageZise, string name, string searchCharacters);
        Task<IEnumerable<Product>> GetServicesOnlyFilteredAndLimited(int pageZise, string fieldName, string searchCharacters);
        Task<IEnumerable<Product>> GetProductsOnlyFilteredAndLimited(int pageZise, string fieldName1,string fieldName2, string searchCharacters);
       Task<IEnumerable<Product>> GetServicesOnlyFilteredAndLimited(int pageZise, string fieldName, string fieldName2, string searchCharacters);
       Task<IEnumerable<Product> >GetFilteredAndLimited(int pageZise, string fieldName, string fieldName2, string searchCharacters);
       Task<Result<Product>> AddWithoutTransaction(Product entity);
       Task<Result<Product>> UpdateWithoutTransaction(Product entity, bool fromDb = true);

        Task<IEnumerable<Product>> GetProductByName( string name);

       Task<Result<Product>> AddRangeWithoutTransaction(List<Product> entity, bool createSequence = false);
    }
}
