using BookStore.API.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BookStore.API.Data.Repositories
{
    /// <inheritdoc cref="IRepository{T}"/>
    public class RepositoryBase<T> : IRepository<T> where T : EntityBase
    {
        protected BookStoreDbContext DbContext { get; }

        public RepositoryBase(BookStoreDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public virtual Task<T?> Get(int id)
        {
            return DbContext.Set<T>().FindAsync(id).AsTask();
        }

        public Task<List<T>?> GetAll()
        {
            return DbContext.Set<T>().ToListAsync()!;
        }

        public Task<List<T>?> GetAll(Expression<Func<T, bool>> predicate)
        {
            return DbContext.Set<T>().AsQueryable().Where(predicate).ToListAsync()!;
        }

        public async Task Add(T entity)
        {
            await DbContext.Set<T>().AddAsync(entity);
            await DbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await DbContext.Set<T>().FindAsync(id);

            if(entity is not null)
                DbContext.Set<T>().Remove(entity);

            await DbContext.SaveChangesAsync();
        }

        public async Task Delete(T entity)
        {
            DbContext.Set<T>().Remove(entity);
            await DbContext.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            DbContext.Update(entity);
            await DbContext.SaveChangesAsync();
        }
    }
}
