using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public interface IProductRepository : IBase<Product>
    {
        IEnumerable<Product> GetProductsOnlyFilteredAndLimited(int pageZise, string name, string searchCharacters);
        IEnumerable<Product> GetServicesOnlyFilteredAndLimited(int pageZise, string fieldName, string searchCharacters);
        IEnumerable<Product> GetProductsOnlyFilteredAndLimited(int pageZise, string fieldName1,string fieldName2, string searchCharacters);
        IEnumerable<Product> GetServicesOnlyFilteredAndLimited(int pageZise, string fieldName, string fieldName2, string searchCharacters);
        IEnumerable<Product> GetFilteredAndLimited(int pageZise, string fieldName, string fieldName2, string searchCharacters);
        Result<Product> AddWithoutTransaction(Product entity);
        Result<Product> UpdateWithoutTransaction(Product entity, bool fromDb = true);

        IEnumerable<Product> GetProductByName( string name);
    }
}
