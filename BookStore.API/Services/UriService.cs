using BookStore.API.Contracts.Requests.Queries;
using Microsoft.AspNetCore.WebUtilities;

namespace BookStore.API.Services
{
    public class UriService : IUriService
    {
        private readonly string _baseUri;

        public UriService(string baseUri)
        {
            _baseUri = baseUri;
        }

        public Uri GetAllBooksUri(string? controllerPathPart = null, PaginationQuery? pagination = null)
        {
            var uri = new Uri(_baseUri);

            if (pagination is null)
                return uri;

            if (controllerPathPart is not null)
                uri = new Uri(uri, controllerPathPart);

            var modifiedUri = QueryHelpers.AddQueryString(uri.AbsoluteUri,
                "pageNumber",
                pagination.PageNumber.ToString());

            modifiedUri = QueryHelpers.AddQueryString(modifiedUri,
                "pageSize",
                pagination.PageSize.ToString());

            return new Uri(modifiedUri);
        }
    }
}
