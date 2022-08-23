using BookStore.API.Models;

namespace BookStore.API.Data.Repositories.Interfaces
{
    /// <summary>
    /// Описывает репозиторий для работы с книгами (<see cref="Book"/>)
    /// </summary>
    public interface IBooksRepository : IRepository<Book>
    {
        Task BuyAsync(int id);

        Task<List<Book>> GetAllAsync(GetAllBooksFilter? filter, PaginationFilter? paginationFilter = null);
    }
}
