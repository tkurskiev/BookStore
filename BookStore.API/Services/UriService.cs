using BookStore.API.Contracts.Requests.Queries;
using Microsoft.AspNetCore.WebUtilities;
using System;

namespace BookStore.API.Services
{
    public class UriService : IUriService
    {
        private readonly string _baseUri;

        public UriService(string baseUri)
        {
            _baseUri = baseUri;
        }

        public Uri GetAllBooksUri(string? controllerPathPart = null, PaginationQuery? pagination = null,
            GetAllBooksQuery? filter = null)
        {
            var uri = new Uri(_baseUri);

            if (controllerPathPart is not null)
                uri = new Uri(uri, controllerPathPart);

            if (pagination is not null)
                uri = new Uri(AddPaginationQuery(uri.AbsoluteUri, pagination));

            if (filter is not null)
                uri = new Uri(AddFilterQuery(uri.AbsoluteUri, filter));

            return uri;
        }

        private static string AddPaginationQuery(string uri, PaginationQuery pagination)
        {
            var modifiedUri = QueryHelpers.AddQueryString(uri,
                "pageNumber",
                pagination.PageNumber.ToString());

            modifiedUri = QueryHelpers.AddQueryString(modifiedUri,
                "pageSize",
                pagination.PageSize.ToString());

            return modifiedUri;
        }

        private string AddFilterQuery(string uri, GetAllBooksQuery filter)
        {
            var modifiedUri = AddPathPart(uri, "author", filter.Author);

            modifiedUri = AddPathPart(modifiedUri, "title", filter.Title);

            modifiedUri = AddPathPart(modifiedUri, "publicationDate", filter.PublicationDate);

            modifiedUri = AddPathPart(modifiedUri, "orderBy", filter.OrderBy);

            return modifiedUri;
        }

        // TODO: More appropriate method name... (QueryPart? FilteringQueryPart?..)
        private string AddPathPart(string uri, string name, string? value) =>
            value is null
                ? uri
                : QueryHelpers.AddQueryString(uri, name, value);
    }
}
