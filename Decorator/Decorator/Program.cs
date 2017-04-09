using System;
using Decorator.Objects.Component;
using Decorator.Objects.ConcreteComponents;
using Decorator.Objects.ConcreteDecorators;

namespace Decorator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Hamburger largeHamburger = new BlueStack();
            largeHamburger = new Cheese(largeHamburger);
            largeHamburger = new Ham(largeHamburger);
            largeHamburger = new Peppers(largeHamburger);

            Console.WriteLine(largeHamburger.GetDescription());
            Console.WriteLine("{0:C2}", largeHamburger.CalculateCost());

            Console.ReadKey();
        }
    }
}