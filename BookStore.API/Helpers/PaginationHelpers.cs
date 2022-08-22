using BookStore.API.Contracts.Requests.Queries;
using BookStore.API.Contracts.Responses;
using BookStore.API.Models;
using BookStore.API.Services;

namespace BookStore.API.Helpers
{
    public class PaginationHelpers
    {
        public static PagedResponse<T> CreatePagedResponse<T>(IUriService uriService, PaginationFilter pagination, List<T> response, string? controllerPathPart = null)
        {
            var nextPage = pagination.PageNumber >= 1
                ? uriService.GetAllBooksUri(controllerPathPart,
                        new PaginationQuery(pagination.PageNumber + 1, pagination.PageSize))
                    .ToString()
                : null;

            var previousPage = pagination.PageNumber - 1 >= 1
                ? uriService.GetAllBooksUri(controllerPathPart,
                        new PaginationQuery(pagination.PageNumber - 1, pagination.PageSize))
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
