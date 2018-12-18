using System.Collections.Generic;
using System.Linq;
using Command.Commands;

namespace Command
{
    public class CommandParser
    {
        readonly IEnumerable<ICommandFactory> availableCommands;

        public CommandParser(IEnumerable<ICommandFactory> availableCommands)
        {
            this.availableCommands = availableCommands;
        }

        internal ICommand ParseCommand(string[] args)
        {
            var requestedCommandName = args[0];

            var command = FindRequestedCommand(requestedCommandName);
            if (null == command)
                return new NotFoundCommand {Name = requestedCommandName};

            return command.MakeCommand(args);
        }

        ICommandFactory FindRequestedCommand(string commandName)
        {
            return availableCommands
                .FirstOrDefault(cmd => cmd.CommandName == commandName);
        }
    }
}