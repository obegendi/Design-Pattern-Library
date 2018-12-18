using System;

namespace Command.Commands
{
    public class ShipOrderCommand : ICommand, ICommandFactory
    {
        public void Execute()
        {
            throw new NotImplementedException();
        }

        public string CommandName
        {
            get { return "ShipOrder"; }
        }

        public string Description
        {
            get { return CommandName; }
        }

        public ICommand MakeCommand(string[] arguments)
        {
            throw new NotImplementedException();
        }
    }
}