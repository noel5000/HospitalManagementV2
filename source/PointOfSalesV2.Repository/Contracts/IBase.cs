using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text; using System.Threading.Tasks;
using System.Threading.Tasks;

namespace PointOfSalesV2.Repository
{
    public interface IBase
    {
    }

    public interface IBase<T> : IBase
      where T : class, ICommonData, new()
    {
        Result<T> Add(T entity);
        void AddRange(IEnumerable<T> entities);

        Result<T> Remove(T entity);

        Result<T> Remove(long id);
        void RemoveRange(IEnumerable<T> entities);

        Result<T> Update(T entity, bool getFromDb = true);

        Result<T> GetAll(string sortExpression = null);

        IPagedList<T> GetPaged(int startRowIndex, int pageSize, string sortExpression = null);

        Result<T> GetAll(Func<IQueryable<T>, IQueryable<T>> transform, Expression<Func<T, bool>> filter = null, string sortExpression = null);

        IQueryable<TResult> GetAll<TResult>(Func<IQueryable<T>, IQueryable<TResult>> transform, Expression<Func<T, bool>> filter = null, string sortExpression = null);

        int GetCount<TResult>(Func<IQueryable<T>, IQueryable<TResult>> transform, Expression<Func<T, bool>> filter = null);

        IPagedList<T> GetPaged(Func<IQueryable<T>, IQueryable<T>> transform, Expression<Func<T, bool>> filter = null, int startRowIndex = -1, int pageSize = -1, string sortExpression = null);

        IPagedList<TResult> GetPaged<TResult>(Func<IQueryable<T>, IQueryable<TResult>> transform, Expression<Func<T, bool>> filter = null, int startRowIndex = -1, int pageSize = -1, string sortExpression = null);

        Result<T> Get(long id);

        Result<T> Get(Guid id);

        TResult Get<TResult>(Func<IQueryable<T>, IQueryable<TResult>> transform, Expression<Func<T, bool>> filter = null, string sortExpression = null);

        bool Exists(long id);

        bool Exists(Func<IQueryable<T>, IQueryable<T>> query, Expression<Func<T, bool>> filter = null);

        #region Async Methods
        Task<Result<T>> AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        void RemoveRangeAsync(IEnumerable<T> entities);
        Task<Result<T>> RemoveAsync(T entity);
         Task<Result<T>> RemoveAsync(long id);
        Task<Result<T>> UpdateAsync(T entity, bool getFromDb = true);
        Task<Result<T>> GetAllAsync(string sortExpression = null);
        Task<Result<T>> GetAllAsync(Func<IQueryable<T>, IQueryable<T>> transform, Expression<Func<T, bool>> filter = null, string sortExpression = null);
        Task<IQueryable<TResult>> GetAllAsync<TResult>(Func<IQueryable<T>, IQueryable<TResult>> transform, Expression<Func<T, bool>> filter = null, string sortExpression = null)
        Task<int> GetCountAsync<TResult>(Func<IQueryable<T>, IQueryable<TResult>> transform, Expression<Func<T, bool>> filter = null);
        Task<Result<T>> GetAsync(long id);
        Task<Result<T>> GetAsync(Guid id);
        Task<TResult> GetAsync<TResult>(Func<IQueryable<T>, IQueryable<TResult>> transform, Expression<Func<T, bool>> filter = null, string sortExpression = null);
        Task<bool> ExistsAsync(long id);
        Task<bool> ExistsAsync(Func<IQueryable<T>, IQueryable<T>> selector, Expression<Func<T, bool>> filter = null);
        #endregion

    }
}
