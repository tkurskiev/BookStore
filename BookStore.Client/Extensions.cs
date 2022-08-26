using System.CommandLine;

namespace BookStore.Client
{
    public static class Extensions
    {
        public static List<Option<T>> AddOption<T>(this List<Option<T>> options, string name, string description, Command command, Action<T?> getOptionNameWithValue, string[] args, params string[] possibleValues)
        {
            var option = new Option<T>(name, description);
            option.FromAmong(possibleValues);
            options.Add(option);

            getOptionNameWithValue(command.Parse(args).GetValueForOption(option));

            return options;

            //options.AddOpton(
            //    name: "--orderBy",
            //    description: "Add sorting of books by the specified field to the get request",
            //    possibleValues: "author", "title", "publicationDate",
            //    ParsedResultHandler));
        }
    }
}
