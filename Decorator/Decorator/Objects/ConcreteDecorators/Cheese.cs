using Decorator.Objects.Component;
using Decorator.Objects.Decorator;

namespace Decorator.Objects.ConcreteDecorators
{
    public class Cheese : PizzaDecorator
    {
        public Cheese(Hamburger hamburger)
            : base(hamburger)
        {
            Description = "Cheese";
        }

        public override string GetDescription()
        {
            return string.Format("{0}, {1}", _pizza.GetDescription(), Description);
        }

        public override double CalculateCost()
        {
            return _pizza.CalculateCost() + 1.25;
        }
    }
}