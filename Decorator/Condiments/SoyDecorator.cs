namespace Decorator.Condiments
{
    public class SoyDecorator : CondimentDecorator
    {
        private readonly BeverageBase _beverageBase;

        public SoyDecorator(BeverageBase beverageBase)
        {
            _beverageBase = beverageBase;
        }

        public override float Cost()
        {
            return _beverageBase.Cost() + 0.15f;
        }

        public override string GetDescription()
        {
            return $"{_beverageBase.Description}, Soy";
        }
    }
}