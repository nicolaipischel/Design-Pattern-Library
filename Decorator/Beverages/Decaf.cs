namespace Decorator.Beverages
{
    public class Decaf : BeverageBase
    {
        public Decaf()
        {
            Description = "Decaffeinated Coffee";
        }
        public override float Cost()
        {
            return 1.05f;
        }
    }
}