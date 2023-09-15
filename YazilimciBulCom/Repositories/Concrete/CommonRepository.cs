using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;
using YazilimciBulCom.Entities.Common;
using YazilimciBulCom.Repositories.Abstract;

namespace YazilimciBulCom.Repositories.Concrete
{
    public class CommonRepository<T> : IRepository<T> where T : CommonEntity
    {
        public DbContext Context { get; set; }
        public CommonRepository(DbContext context)
        {
            Context = context;
        }

        public DbSet<T> Table => Context.Set<T>();


        public async Task<T?> GetSingleAsync(Expression<Func<T, bool>> filter)
        {
            return await Table.SingleOrDefaultAsync(filter);
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>>? filter = null, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, bool tracking = false)
        {
            IQueryable<T> queryable = Table.AsQueryable();

            if (!tracking)
                queryable = queryable.AsNoTracking();

            if (include != null)
                queryable = include(queryable);

            if (filter != null)
                queryable = queryable.Where(filter);

            return queryable;
        }

        public async Task<T> AddAsync(T entity)
        {
            Context.Entry(entity).State = EntityState.Added;
            await Context.SaveChangesAsync();
            return entity;
        }

        public async Task<T> UpdateAsync(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            await Context.SaveChangesAsync();
            return entity;
        }

        public async Task<T> DeleteAsync(T entity)
        {
            Context.Entry(entity).State = EntityState.Deleted;
            await Context.SaveChangesAsync();
            return entity;
        }

    }
}