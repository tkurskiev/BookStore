using BookStore.API.Data.Repositories.Interfaces;
using BookStore.API.Exceptions;
using BookStore.API.Models;

namespace BookStore.API.Data.Repositories.Implementations
{
    /// <inheritdoc cref="IBookRepository"/>
    public class BookRepository : RepositoryBase<Book>, IBookRepository
    {
        public BookRepository(BookStoreDbContext dbContext) : base(dbContext)
        {
        }

        /// <exception cref="DbException"></exception>
        public Task BuyAsync(int id) => DeleteAsync(id);
    }
}
