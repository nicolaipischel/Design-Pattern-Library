namespace Decorator.Beverages
{
    public class DarkRoast : BeverageBase
    {
        public DarkRoast()
        {
            Description = "Dark Roasted Coffee";
        }

        public override float Cost()
        {
            return .99f;
        }
    }
}