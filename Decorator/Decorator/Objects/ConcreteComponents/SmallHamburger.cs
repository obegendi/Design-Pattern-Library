using Decorator.Objects.Component;

namespace Decorator.Objects.ConcreteComponents
{
    public class SmallHamburger : Hamburger
    {
        public SmallHamburger()
        {
            Description = "Small Hamburger";
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override double CalculateCost()
        {
            return 3.00;
        }
    }
}