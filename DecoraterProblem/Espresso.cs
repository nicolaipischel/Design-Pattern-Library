namespace DecoraterProblem;

public class Espresso : Beverage
{
  public Espresso() => Description = "Finest Espresso";
  public override double Cost() => 1.99 + base.Cost();
}