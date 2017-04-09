using Decorator.Objects.Component;
using Decorator.Objects.Decorator;

namespace Decorator.Objects.ConcreteDecorators
{
    public class Peppers : PizzaDecorator
    {
        public Peppers(Hamburger pizza)
            : base(pizza)
        {
            Description = "Peppers";
        }

        public override string GetDescription()
        {
            return string.Format("{0}, {1}", _pizza.GetDescription(), Description);
        }

        public override double CalculateCost()
        {
            return _pizza.CalculateCost() + 2.00;
        }
    }
}