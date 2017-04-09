using Decorator.Objects.Component;

namespace Decorator.Objects.ConcreteComponents
{
    public class StandardSizeHamburger : Hamburger
    {
        public StandardSizeHamburger()
        {
            Description = "Standard Hamburger";
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override double CalculateCost()
        {
            return 6.00;
        }
    }
}