namespace Decorator.Beverages
{
    public class HouseBlend : BeverageBase
    {
        public HouseBlend()
        {
            Description = "House Blend Coffee";
        }
        public override float Cost()
        {
            return .89f;
        }
    }
}