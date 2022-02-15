namespace Decorator.Beverages
{
    public class Espresso : BeverageBase
    {
        public Espresso()
        {
            Description = $"{nameof(Espresso)}";
        }
        public override float Cost()
        {
            return 1.99f;
        }
    }
}