namespace Decorator.Objects.Component
{
    public abstract class Hamburger
    {
        public string Description { get; set; }

        public abstract string GetDescription();

        public abstract double CalculateCost();
    }
}