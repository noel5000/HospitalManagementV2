using PointOfSalesV2.Entities;
using PointOfSalesV2.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text; using System.Threading.Tasks;

namespace PointOfSalesV2.Repository
{
    public interface IUserRepository : IBase<User>
    {
        Task<User> Login(Login login,string tokenKey);
    }
}
