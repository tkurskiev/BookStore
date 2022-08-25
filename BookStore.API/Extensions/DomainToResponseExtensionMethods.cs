using BookStore.API.Contracts.Requests.Queries;
using BookStore.API.Contracts.Responses;
using BookStore.API.Models;

namespace BookStore.API.Extensions
{
    public static class DomainToResponseExtensionMethods
    {
        public static BookResponse ToBookResponse(this Book book)
        {
            return new BookResponse
            {
                Id = book.Id,
                Title = book.Title,
                Author = book.Author,
                PublicationDate = book.PublicationDate
            };
        }

        public static GetAllBooksQuery ToGetAllBooksQuery(this GetAllBooksFilter getAllBooksFilter)
        {
            return new GetAllBooksQuery
            {
                Author = getAllBooksFilter.Author,
                Title = getAllBooksFilter.Title,
                // TODO: yyyy-MM-dd - receive from outside?
                PublicationDate = getAllBooksFilter.PublicationDate?.ToString("yyyy-MM-dd"),
                OrderBy = getAllBooksFilter.OrderBy
            };
        }
    }
}
