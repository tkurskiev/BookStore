using System.CommandLine;

namespace BookStore.Client
{
    public class CommandWithOptions<T>
    {
        private readonly Command _command;
        private readonly List<Option<T>> _options;

        public CommandWithOptions(Command command, List<Option<T>> options)
        {
            _command = command;
            _options = options;
        }

        public IEnumerable<string?> GetValues(string[] args)
        {
            var parseResult = _command.Parse(args);

            return Enumerable.Empty<string?>();
        }
    }
}
