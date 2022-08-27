using BookStore.API.Contracts.Responses;
using BookStore.Client.Commands;
using CommandLine;

namespace BookStore.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            #region Command line arguments test data

#if Test

            //args = new[] {"get", "--orderBy=title", "--pageNumber", "1", "--pageSize", "10", "--title", "Test"};

            //args = new[] {"buy", "--id=87"};

#endif

            #endregion

            Console.WriteLine(@"Client for making http requests to the BookStore.API.
In order to get help, use:
'dotnet run -- --help'

First '--' is required as per the .NET Core CLI documentation, '--' delimits arguments to dotnet run
from arguments for the application being run. All arguments after this one are passed
to the application run.

");

            IBookStoreClient client = new BookStoreClient(new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7190")
            });

            await Parser.Default.ParseArguments<GetOptions, GetByUriOptions, BuyOptions>(args)
                .MapResult<GetOptions, GetByUriOptions, BuyOptions, Task>(
                    parsedFunc1: (GetOptions opts) => RunOptionsAsync(opts, client),
                    parsedFunc2: (GetByUriOptions opts) => RunOptionsAsync(opts, client),
                    parsedFunc3: (BuyOptions opts) => RunOptionsAsync(opts, client),
                    notParsedFunc: errors =>
                    {
                        return new Task(() => HandleParseError(errors));
                    });
        }

        public static async Task RunOptionsAsync(GetOptions opts, IBookStoreClient client)
        {
            try
            {
                var filterQuery = opts.GetFilterQuery();

                Console.WriteLine($"Resultant filter query string: {filterQuery}");

                var books = await client.GetAllBooksAsync(filterQuery);

                PrintOutBooksResponse(books!);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Request failed with {ex.StatusCode}. Message: {ex.Message}");
            }
        }

        public static async Task RunOptionsAsync(GetByUriOptions opts, IBookStoreClient client)
        {
            try
            {
                var books = await client.GetByUriAsync(opts.Uri);

                PrintOutBooksResponse(books!);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Request failed with {ex.StatusCode}. Message: {ex.Message}");
            }
        }

        public static async Task RunOptionsAsync(BuyOptions opts, IBookStoreClient client)
        {
            try
            {
                var responseMessage = await client.BuyAsync(opts.Id);

                Console.WriteLine(responseMessage);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Request failed with {ex.StatusCode}. Message: {ex.Message}");
            }
        }

        public static void HandleParseError(IEnumerable<Error> errs)
        {
            foreach (var error in errs)
            {
                Console.WriteLine($@"Error tag: {error.Tag}, stops processing: {error.StopsProcessing},
{error}");
            }
        }

        private static void PrintOutBooksResponse(PagedResponse<BookResponse> response)
        {
            Console.WriteLine("We got the response:");
            foreach (var book in response.Data)
            {
                Console.WriteLine($"Id: {book.Id}, Author: {book.Author}, Title: '{book.Title}', published: {book.PublicationDate:yyyy-MM-dd}");
            }
            Console.WriteLine($@"Page number: {response.PageNumber}, page size: {response.PageSize},
next page: {response.NextPage ?? "null"}
previous page: {response.PreviousPage ?? "null"}");
        }
    }
}