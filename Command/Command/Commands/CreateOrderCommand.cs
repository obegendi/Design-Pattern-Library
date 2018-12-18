using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    public class CreateOrderCommand : ICommand, ICommandFactory
    {
        public void Execute()
        {
            throw new NotImplementedException();
        }

        public string CommandName
        {
            get { return "CreateOrder"; }
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
