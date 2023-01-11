

namespace PointOfSalesV2.Repository
{
    public interface IUserRepository : IBase<User>
    {
        Task<User> Login(Login login,string tokenKey);
    }
}
