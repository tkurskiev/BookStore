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

        public Uri GetAllBooksUri(PaginationQuery? pagination = null)
        {
            var uri = new Uri(_baseUri);

            if (pagination is null)
                return uri;

            var modifiedUri = QueryHelpers.AddQueryString(_baseUri, 
                "pageNumber", 
                pagination.PageNumber.ToString());

            modifiedUri = QueryHelpers.AddQueryString(modifiedUri,
                "pageSize",
                pagination.PageSize.ToString());

            return new Uri(modifiedUri);
        }
    }
}
