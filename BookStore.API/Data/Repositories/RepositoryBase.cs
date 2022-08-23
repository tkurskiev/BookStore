using BookStore.API.Exceptions;
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

        public virtual Task<T?> GetAsync(int id)
        {
            return DbContext.Set<T>().FindAsync(id).AsTask();
        }

        public virtual Task<List<T>> GetAllAsync(PaginationFilter? paginationFilter = null)
        {
            var queryable = DbContext.Set<T>().AsQueryable();

            if (paginationFilter is not null)
                queryable = AddPaginationFiltersOnQuery(paginationFilter, queryable);

            return queryable
                .OrderBy(x => x.Id)
                .ToListAsync();
        }

        public Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate)
        {
            return DbContext.Set<T>().AsQueryable().Where(predicate).ToListAsync();
        }

        /// <exception cref="DbException"></exception>
        public async Task<T> AddAsync(T entity)
        {
            try
            {
                await DbContext.Set<T>().AddAsync(entity);
                await DbContext.SaveChangesAsync();

                return entity;
            }
            catch (DbUpdateException ex)
            {
                throw new DbException($@"Error occurred while adding new entity to database:
{ex.GetType()}: {ex.Message}
{ex.InnerException?.Message}", ex);
            }
        }

        /// <exception cref="DbException"></exception>
        public async Task DeleteAsync(int id)
        {
            try
            {
                var entity = await DbContext.Set<T>().FindAsync(id);

                if (entity is null)
                    throw new DbException($"There's no such entity of type {typeof(T)} in the database with the given id = {id}");

                DbContext.Set<T>().Remove(entity);

                await DbContext.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                throw new DbException($@"Error occurred while deleting entity by id from database:
{ex.GetType()}: {ex.Message}
{ex.InnerException?.Message}", ex);
            }
        }

        /// <exception cref="DbException"></exception>
        public async Task DeleteAsync(T entity)
        {
            try
            {
                DbContext.Set<T>().Remove(entity);
                await DbContext.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                throw new DbException($@"Error occurred while deleting entity from database:
{ex.GetType()}: {ex.Message}", ex);
            }
        }

        /// <exception cref="DbException"></exception>
        public async Task UpdateAsync(T entity)
        {
            try
            {
                DbContext.Update(entity);
                await DbContext.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                throw new DbException($@"Error occurred while updating entity in the database:
{ex.GetType()}: {ex.Message}", ex);
            }
        }

        protected IQueryable<T> AddPaginationFiltersOnQuery(PaginationFilter paginationFilter, IQueryable<T> queryable)
        {
            var skip = (paginationFilter.PageNumber - 1) * paginationFilter.PageSize;

            return queryable
                .Skip(skip)
                .Take(paginationFilter.PageSize);
        }
    }
}
