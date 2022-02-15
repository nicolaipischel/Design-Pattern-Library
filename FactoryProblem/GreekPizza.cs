namespace FactoryProblem;

public class GreekPizza : Pizza
{
  public override void Prepare() =>
    Console.WriteLine("Pizza is being prepared with tasty sauce, fresh feta, onion, olives and tomato");

  public override void Bake() => Console.WriteLine("Pizza is being baked in a shallow metal pan with a thin spongy crust");

  public override void Box() => Console.WriteLine("Pizza is packaged in 3rd party box");
}