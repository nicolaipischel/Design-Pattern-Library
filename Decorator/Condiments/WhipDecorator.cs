namespace Decorator.Condiments
{
    public class WhipDecorator : CondimentDecorator
    {
        private readonly BeverageBase _beverageBase;

        public WhipDecorator(BeverageBase beverageBase)
        {
            _beverageBase = beverageBase;
        }

        public override float Cost()
        {
            return _beverageBase.Cost() + 0.10f;
        }

        public override string GetDescription()
        {
            return $"{_beverageBase.Description}, Whip";
        }
    }
}