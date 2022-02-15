namespace DecoraterProblem;

public class DarkRoast : Beverage
{
  public DarkRoast() => Description = "Most Excellent Dark Roast";
  public override double Cost() => .99 + base.Cost();
}