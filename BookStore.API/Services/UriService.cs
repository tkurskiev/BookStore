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
            GetAllBooksQuery? getAllBooksQuery = null)
        {
            var uri = new Uri(_baseUri);

            if (controllerPathPart is not null)
                uri = new Uri(uri, controllerPathPart);

            if (pagination is not null)
                uri = new Uri(AddPaginationQuery(uri.AbsoluteUri, pagination));

            if (getAllBooksQuery is not null)
                uri = new Uri(AddGetAllBooksQuery(uri.AbsoluteUri, getAllBooksQuery));

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

        private string AddGetAllBooksQuery(string uri, GetAllBooksQuery getAllBooksQuery)
        {
            var modifiedUri = AddPathPart(uri, "author", getAllBooksQuery.Author);

            modifiedUri = AddPathPart(modifiedUri, "title", getAllBooksQuery.Title);

            modifiedUri = AddPathPart(modifiedUri, "publicationDate", getAllBooksQuery.PublicationDate);

            modifiedUri = AddPathPart(modifiedUri, "orderBy", getAllBooksQuery.OrderBy);

            return modifiedUri;
        }

        // TODO: More appropriate method name... (QueryPart? FilteringQueryPart?..)
        private string AddPathPart(string uri, string name, string? value) =>
            value is null
                ? uri
                : QueryHelpers.AddQueryString(uri, name, value);
    }
}
