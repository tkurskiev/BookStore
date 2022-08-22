using BookStore.API.Contracts.Requests.Queries;

namespace BookStore.API.Services
{
    public interface IUriService
    {
        Uri GetAllBooksUri(PaginationQuery? pagination = null);
    }
}
