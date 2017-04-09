using Decorator.Objects.Component;

namespace Decorator.Objects.Decorator
{
    public class PizzaDecorator : Hamburger
    {
        protected Hamburger _pizza;

        public PizzaDecorator(Hamburger pizza)
        {
            _pizza = pizza;
        }

        public override string GetDescription()
        {
            return _pizza.Description;
        }

        public override double CalculateCost()
        {
            return _pizza.CalculateCost();
        }
    }
}