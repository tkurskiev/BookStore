using System.CommandLine;

namespace BookStore.Client
{
    public class CliBuilder
    {
        private readonly RootCommand _rootCommand;

        public CliBuilder(string description)
        {
            _rootCommand = new RootCommand(description);
            //_commands = new List<Command>();
        }

        public CliBuilder AddCommand<T>(string name, string description, Action<Command, List<Option<T>>> configureOptions)
        {
            var command = new Command(name, description);

            var options = new List<Option<T>>();
            configureOptions(command, options);

            foreach (var option in options)
            {
                command.AddOption(option);
            }

            _rootCommand.AddCommand(command);

            return this;
        }

        public RootCommand Build(params string[] args)
        {
            return _rootCommand;
        }
    }
}
