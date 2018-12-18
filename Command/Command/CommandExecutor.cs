using System;

namespace Command
{
    public class CommandExecutor
    {
        internal void ExecuteCommand(string[] args)
        {
            switch (args[0])
            {
                case "UpdateQuantity":
                    UpdateQuantity(int.Parse(args[1]));
                    break;
                case "CreateOrder":
                    CreateOrder();
                    break;
                case "ShipOrder":
                    ShipOrder();
                    break;
                default:
                    Console.WriteLine("Unrecognized command");
                    break;
            }
        }

        private void UpdateQuantity(int newQuantity)
        {
            // simulate updating a database
            const int oldQuantity = 5;
            Console.WriteLine("DATABASE: Updated");

            // simulate logging
            Console.WriteLine("LOG: Updated order quantity from {0} to {1}", oldQuantity, newQuantity);
        }

        void CreateOrder() {}
        void ShipOrder() {}
    }
}