using CommandLine;

namespace BookStore.Client.Commands
{
    [Verb("buy",
        HelpText = "Makes HttpPost request to the BookStore.API with the id of the book to buy. By default to the 'api/books' path.")]
    public class BuyOptions
    {
        [Option("id",
            HelpText = "Specify the id of the book to buy",
            Required = true)]
        public int Id { get; set; }
    }
}
