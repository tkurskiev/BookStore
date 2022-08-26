using CommandLine;
using Microsoft.AspNetCore.WebUtilities;

namespace BookStore.Client.Commands
{
    [Verb("get",
        HelpText = "Makes HttpGet request to the BookStore.API. By default to the 'api/books' path.")]
    public class GetOptions
    {
        [Option("author",
            HelpText = "Add filtering of books by the author to the get request",
            Required = false)]
        public string? Author { get; set; }

        [Option("title",
            HelpText = "Add filtering of books by the title to the get request",
            Required = false)]
        public string? Title { get; set; }

        [Option("date",
            HelpText = "Add filtering of books by the publication date to the get request. Use 'yyyy-MM-dd' format",
            Required = false)]
        public string? PublicationDate { get; set; }

        [Option("orderBy",
            HelpText = "Add sorting of books by the specified field to the get request",
            Required = false)]
        public string? OrderBy { get; set; }

        [Option("pageNumber",
            HelpText = "Specify the page of the result data of the get request",
            Required = false)]
        public int? PageNumber { get; set; }

        [Option("pageSize",
            HelpText = "Specify the page size for the result data of the get request",
            Required = false)]
        public int? PageSize { get; set; }

        // TODO: QueryHelpers.AddQ..String
        public string GetFilterQuery()
        {
            //https://localhost:7190/api/books?pageNumber=2&pageSize=100

            var result = "?";

            if(!string.IsNullOrEmpty(Author))
                result = QueryHelpers.AddQueryString(result, "author", Author);

            if(!string.IsNullOrEmpty(Title))
                result = QueryHelpers.AddQueryString(result, "title", Title);

            if(!string.IsNullOrEmpty(PublicationDate))
                result = QueryHelpers.AddQueryString(result, "publicationDate", PublicationDate);

            if (!string.IsNullOrEmpty(OrderBy))
                result = QueryHelpers.AddQueryString(result, "orderBy", OrderBy);

            if (PageNumber is not null)
                result = QueryHelpers.AddQueryString(result, "pageNumber", PageNumber.Value.ToString());

            if(PageSize is not null)
                result = QueryHelpers.AddQueryString(result, "pageSize", PageSize.Value.ToString());

            result.TrimEnd('?');

            return result;
        }
    }
}
