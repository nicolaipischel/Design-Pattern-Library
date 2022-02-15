namespace Decorator.Condiments
{
    public class MochaDecorator : CondimentDecorator
    {
        private readonly BeverageBase _beverageBase;

        public MochaDecorator(BeverageBase beverageBase)
        {
            _beverageBase = beverageBase;
        }
        public override float Cost()
        {
            return _beverageBase.Cost() + .20f;
        }

        public override string GetDescription()
        {
            return $"{_beverageBase.Description}, Mocha";
        }
    }
}