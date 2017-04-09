using Decorator.Objects.Component;

namespace Decorator.Objects.ConcreteComponents
{
    public class BlueStack : Hamburger
    {
        public BlueStack()
        {
            Description = "Large Bluestack Hamburger";
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override double CalculateCost()
        {
            return 9.00;
        }
    }
}