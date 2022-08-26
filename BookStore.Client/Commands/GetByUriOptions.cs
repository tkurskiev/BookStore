using CommandLine;

namespace BookStore.Client.Commands
{
    [Verb("getByUri",
        HelpText = "Makes HttpGet request to the BookStore.API with the given uri.")]
    public class GetByUriOptions
    {
        [Option("uri",
            HelpText = @"The request's URI. (Should be valid URI-string). Example:
https://localhost:7190/api/books?pageNumber=1&pageSize=10",
            Required = true)]
        public string? Uri { get; set; }
    }
}
