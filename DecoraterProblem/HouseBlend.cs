namespace DecoraterProblem;

public class HouseBlend : Beverage
{
  public HouseBlend() => Description = "House Blend Coffee";
  public override double Cost() => .89 + base.Cost();
}