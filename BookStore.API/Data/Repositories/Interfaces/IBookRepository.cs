using BookStore.API.Models;

namespace BookStore.API.Data.Repositories.Interfaces
{
    /// <summary>
    /// Описывает репозиторий для работы с книгами (<see cref="Book"/>)
    /// </summary>
    public interface IBookRepository : IRepository<Book>
    {
        Task BuyAsync(int id);
    }
}
