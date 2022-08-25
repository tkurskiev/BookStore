using BookStore.API.Contracts.Requests.Queries;
using BookStore.API.Contracts.Responses;
using BookStore.API.Extensions;
using BookStore.API.Models;
using BookStore.API.Services;

namespace BookStore.API.Helpers
{
    public class PaginationHelpers
    {
        public static PagedResponse<T> CreatePagedResponse<T>(IUriService uriService, List<T> response, PaginationFilter pagination, GetAllBooksFilter? getAllBooksFilter = null, string? controllerPathPart = null)
        {
            var getAllBooksQuery = getAllBooksFilter?.ToGetAllBooksQuery();

            var nextPage = pagination.PageNumber >= 1
                ? uriService.GetAllBooksUri(controllerPathPart,
                        new PaginationQuery(pagination.PageNumber + 1, pagination.PageSize),
                        getAllBooksQuery)
                    .ToString()
                : null;

            var previousPage = pagination.PageNumber - 1 >= 1
                ? uriService.GetAllBooksUri(controllerPathPart,
                        new PaginationQuery(pagination.PageNumber - 1, pagination.PageSize),
                        getAllBooksQuery)
                    .ToString()
                : null;

            return new PagedResponse<T>(response)
            {
                PageNumber = pagination.PageNumber >= 1 ? pagination.PageNumber : null,
                PageSize = pagination.PageSize >= 1 ? pagination.PageSize : null,
                NextPage = response.Count >= pagination.PageSize ? nextPage : null,
                PreviousPage = previousPage
            };
        }
    }
}
