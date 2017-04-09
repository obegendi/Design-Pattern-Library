using Decorator.Objects.Component;
using Decorator.Objects.Decorator;

namespace Decorator.Objects.ConcreteDecorators
{
    public class Ham : PizzaDecorator
    {
        public Ham(Hamburger hamburger)
            : base(hamburger)
        {
            Description = "Ham";
        }

        public override string GetDescription()
        {
            return string.Format("{0}, {1}", _pizza.GetDescription(), Description);
        }

        public override double CalculateCost()
        {
            return _pizza.CalculateCost() + 1.00;
        }
    }
}