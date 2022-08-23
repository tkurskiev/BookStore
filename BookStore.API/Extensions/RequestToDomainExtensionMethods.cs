using BookStore.API.Contracts.Requests;
using BookStore.API.Contracts.Requests.Queries;
using BookStore.API.Models;

namespace BookStore.API.Extensions
{
    public static class RequestToDomainExtensionMethods
    {
        public static Book ToBook(this AddNewRequest request)
        {
            return new Book
            {
                Author = request.Author,
                Title = request.Title,
                PublicationDate = request.PublicationDate
            };
        }

        public static PaginationFilter ToPaginationFilter(this PaginationQuery paginationQuery)
        {
            return new PaginationFilter
            {
                PageNumber = paginationQuery.PageNumber,
                PageSize = paginationQuery.PageSize
            };
        }

        public static GetAllBooksFilter ToGetAllBooksFilter(this GetAllBooksQuery getAllBooksQuery)
        {
            return new GetAllBooksFilter
            {
                Author = getAllBooksQuery.Author,
                Title = getAllBooksQuery.Title,
                PublicationDate = getAllBooksQuery.PublicationDate is null
                    ? null
                    : DateTime.Parse(getAllBooksQuery.PublicationDate),
                OrderBy = getAllBooksQuery.OrderBy
            };
        }
    }
}
