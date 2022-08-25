using BookStore.API.Contracts.Requests.Queries;

namespace BookStore.API.Services
{
    public interface IUriService
    {
        Uri GetAllBooksUri(string? controllerPathPart = null, PaginationQuery? pagination = null,
            GetAllBooksQuery? filter = null);
    }
}
