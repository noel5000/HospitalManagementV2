

namespace PointOfSalesV2.Repository
{
    public interface IDataRepositoryFactory
    {
        IBase<T> GetDataRepositories<T>() where T : class, ICommonData, new();
        TRepositories GetCustomDataRepositories<TRepositories>() where TRepositories : IBase;
        IUnitOfWork GetUnitOfWork();
    }
}
