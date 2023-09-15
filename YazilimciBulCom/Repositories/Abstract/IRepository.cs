using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;
using YazilimciBulCom.Entities.Common;

namespace YazilimciBulCom.Repositories.Abstract
{
    public interface IRepository<T> where T : CommonEntity
    {
        DbSet<T> Table { get; }

        IQueryable<T> GetAll(Expression<Func<T, bool>>? filter = null, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, bool tracking = false);

        Task<T?> GetSingleAsync(Expression<Func<T, bool>> filter);

        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(T entity);
    }
}
