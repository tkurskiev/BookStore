using BookStore.API.Contracts.Responses;
using Newtonsoft.Json;
using System.CommandLine;

namespace BookStore.Client
{
    internal class Program
    {
        //private static string _query = "api/books?";
        private static List<string> _queryParameters = new();

        static async Task Main(string[] args)
        {
            foreach (var argument in args)
            {
                Console.WriteLine($"'{argument}'");
            }

            //return;

            var rootCommand = await SetupCommands();
            //rootCommand.SetHandler(x =>
            //{
            //    Console.WriteLine(x.BindingContext.ParseResult);
            //    Console.WriteLine("TEST");
            //});

            await rootCommand.InvokeAsync(args);

            var queryString = string.Empty;

            if (_queryParameters.Count > 0)
                queryString = _queryParameters.Skip(1).Aggregate($"?{_queryParameters[0]}",
                    (currentQueryString, nextQueryParameter) =>
                        currentQueryString = $"{currentQueryString}&{nextQueryParameter}");

            Console.WriteLine($"Resultant query string is: {queryString}");

            await ClientTestAsync(queryString);

            //Console.WriteLine(_queryParameters.Aggregate("?", (queryString, nextQueryParameter) =>
            //    queryString = $"{queryString}&{nextQueryParameter}"));
        }

        static async Task ClientTestAsync(string filterQuery)
        {
            var client = new HttpClient()
            {
                BaseAddress = new Uri("https://localhost:7190/")
            };

            //var testString =
            //    "{\"data\":[{\"id\":11,\"author\":\"Beatrix Potter\",\"title\":\"The Tale of Peter Rabbit\",\"publicationDate\":\"1902-06-03T00:00:00\"}],\"pageNumber\":1,\"pageSize\":100,\"nextPage\":\"https://localhost:7190/api/books?pageNumber=2&pageSize=100\",\"previousPage\":null}";

            //var test3 = Newtonsoft.Json.JsonSerializer.

            var responseMessage = await client.GetAsync($"api/Books/{filterQuery}");

            //var test2 = await test.Content.ReadAsStringAsync();

            var serializer = new JsonSerializer();
            using var reader = new JsonTextReader(new StreamReader(await responseMessage.Content.ReadAsStreamAsync()));

            var response = serializer.Deserialize<PagedResponse<BookResponse>>(reader) ??
                           // TODO:
                           new PagedResponse<BookResponse>(Enumerable.Empty<BookResponse>());

            Console.WriteLine("We got the response:");
            foreach (var book in response.Data)
            {
                Console.WriteLine($"Id: {book.Id}, Author: {book.Author}, Title: '{book.Title}', published: {book.PublicationDate:yyyy-MM-dd}");
            }
            Console.WriteLine($@"Page number: {response.PageNumber}, page size: {response.PageSize},
next page: {response.NextPage ?? "null"}
previous page: {response.PreviousPage ?? "null"}");
        }

        static async Task<RootCommand> SetupCommands()
        {
            var rootCommand = new RootCommand("Client for making http requests to the BookStore.API");

            var getCommand = new Command("get",
                "Makes HttpGet request to the BookStore.API. By default to the 'api/books' path");

            await SetUpGetCommand(getCommand);

            var buyCommand = new Command("buy",
                "Makes HttpPost request for buying a book to the BookStore.API. By default to the 'api/books' path");

            rootCommand.AddCommand(getCommand);
            rootCommand.AddCommand(buyCommand);

            return rootCommand;
        }

        static async Task SetUpGetCommand(Command getCommand)
        {
            var filterByAuthor = new Option<string>(
                name: "--author",
                description: "Add filtering of books by the author to the get request");
            //filterByAuthor.FromAmong()

            var filterByTitle = new Option<string>(
                name: "--title",
                description: "Add filtering of books by the title to the get request");

            var filterByPublicationDate = new Option<string>(
                name: "--publicationDate",
                description: "Add filtering of books by the publication date to the get request");

            var orderBy = new Option<string>(
                name: "--orderBy",
                description: "Add sorting of books by the specified field to the get request");
            orderBy.FromAmong("author", "title", "publicationDate");

            var pageNumber = new Option<string>(
                name: "--pageNumber",
                description: "Specify the page of the result data of the get request");

            var pageSize = new Option<string>(
                name: "--pageSize",
                description: "Specify the page size for the result data of the get request");

            getCommand.AddOption(filterByAuthor);
            getCommand.AddOption(filterByTitle);
            getCommand.AddOption(filterByPublicationDate);
            getCommand.AddOption(pageNumber);
            getCommand.AddOption(pageSize);
            getCommand.AddOption(orderBy);

            getCommand.SetHandler(
                (filterByAuthorValue,
                    filterByTitleValue,
                    filterByPublicationDateValue,
                    pageNumberValue,
                    pageSizeValue,
                    orderByValue) =>
                {
                    if(!string.IsNullOrWhiteSpace(filterByAuthorValue))
                        _queryParameters.Add($"{filterByAuthor.Name}={filterByAuthorValue}");

                    if (!string.IsNullOrWhiteSpace(filterByTitleValue))
                        _queryParameters.Add($"{filterByTitle.Name}={filterByTitleValue}");

                    if (!string.IsNullOrWhiteSpace(filterByPublicationDateValue))
                        _queryParameters.Add($"{filterByPublicationDate.Name}={filterByPublicationDate}");

                    if (!string.IsNullOrWhiteSpace(orderByValue))
                        _queryParameters.Add($"{orderBy.Name}={orderByValue}");

                    if (!string.IsNullOrWhiteSpace(pageNumberValue) && !string.IsNullOrWhiteSpace(pageSizeValue))
                    {
                        _queryParameters.Add($"{pageNumber.Name}={pageNumberValue}");
                        _queryParameters.Add($"{pageSize.Name}={pageSizeValue}");
                    }
                }, 
                filterByAuthor, 
                filterByTitle, 
                filterByPublicationDate, 
                pageNumber,
                pageSize,
                orderBy);
        }

        static async Task<int> CommandLineTestMethod(string[] args)
        {
            var fileOption = new Option<FileInfo?>(
                name: "--file",
                description: "The file to read and display on the console.");

            var rootCommand = new RootCommand("Sample app for System.CommandLine");
            rootCommand.AddOption(fileOption);

            rootCommand.SetHandler((file) =>
                {
                    ReadFile(file!);
                },
                fileOption);

            return await rootCommand.InvokeAsync(args);
        }

        static void ReadFile(FileInfo file)
        {
            try
            {
                File.ReadLines(file.FullName).ToList()
                    .ForEach(line => Console.WriteLine(line));
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}