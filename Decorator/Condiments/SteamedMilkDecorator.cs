using Decorator.V2;

namespace Decorator.Condiments
{
    public class SteamedMilkDecorator : CondimentDecorator
    {
        private readonly BeverageBase _beverageBase;

        public SteamedMilkDecorator(BeverageBase beverageBase)
        {
            _beverageBase = beverageBase;
        }

        public override float Cost()
        {
            return _beverageBase.Cost() + .10f;
        }

        public override string GetDescription()
        {
            return $"{_beverageBase.Description}, Steamed Milk";
        }
    }
}