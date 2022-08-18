using BookStore.API.Data.Repositories.Interfaces;
using BookStore.API.Models;

namespace BookStore.API.Data.Repositories.Implementations
{
    /// <inheritdoc cref="IBookRepository"/>
    public class BookRepository : RepositoryBase<Book>, IBookRepository
    {
        public BookRepository(BookStoreDbContext dbContext) : base(dbContext)
        {
        }
    }
}
