using System;

namespace Command.Commands
{
    public class UpdateQuantityCommand : ICommand, ICommandFactory
    {
        public int NewQuantity { get; set; }

        public void Execute()
        {
            // simulate updating a database
            const int oldQuantity = 5;
            Console.WriteLine("DATABASE: Updated");

            // simulate logging
            Console.WriteLine("LOG: Updated order quantity from {0} to {1}", oldQuantity, NewQuantity);
        }

        public string CommandName { get { return "UpdateQuantity"; } }
        public string Description { get { return "UpdateQuantity number"; } }

        public ICommand MakeCommand(string[] arguments)
        {
            return new UpdateQuantityCommand {NewQuantity = int.Parse(arguments[1])};
        }
    }
}