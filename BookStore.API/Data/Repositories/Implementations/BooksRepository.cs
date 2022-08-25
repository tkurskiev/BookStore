using System.Linq.Dynamic.Core;
using BookStore.API.Data.Repositories.Interfaces;
using BookStore.API.Exceptions;
using BookStore.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.API.Data.Repositories.Implementations
{
    /// <inheritdoc cref="IBooksRepository"/>
    public class BooksRepository : RepositoryBase<Book>, IBooksRepository
    {
        public BooksRepository(BookStoreDbContext dbContext) : base(dbContext)
        {
        }

        /// <exception cref="DbException"></exception>
        public Task BuyAsync(int id) => DeleteAsync(id);

        public Task<List<Book>> GetAllAsync(GetAllBooksFilter? filter, PaginationFilter? paginationFilter = null)
        {
            var queryable = DbContext.Books.AsQueryable();

            if (filter is not null)
                queryable = AddFiltersOnQuery(filter, queryable);

            if (paginationFilter is not null)
                queryable = AddPaginationFiltersOnQuery(paginationFilter, queryable);

            return queryable.ToListAsync();
        }

        private IQueryable<Book> AddFiltersOnQuery(GetAllBooksFilter filter, IQueryable<Book> queryable)
        {
            if (!string.IsNullOrWhiteSpace(filter.Author))
                queryable = queryable.Where(x => x.Author == filter.Author);

            if(!string.IsNullOrWhiteSpace(filter.Title))
                queryable = queryable.Where(x => EF.Functions.Like(x.Title!, $"%{filter.Title}%"));

            if (filter.PublicationDate is not null)
            {
                queryable = queryable.Where(x =>
                    x.PublicationDate.Date == filter.PublicationDate.Value.Date);
            }

            if (filter.OrderBy is not null)
            {
                queryable = queryable.OrderBy(ParsingConfig.Default, filter.OrderBy);
            }

            return queryable;
        }
    }
}
