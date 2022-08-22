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
    }
}
