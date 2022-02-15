namespace FactoryMethod.CaliforniaStyle;

public class CaliforniaStyleGreekPizza : Pizza
{
  public override void Prepare() =>
    Console.WriteLine("Pizza is being prepared with tasty sauce, fresh feta, onion, olives and tomato");

  public override void Bake() => Console.WriteLine("Pizza is being baked in a shallow metal pan with a thin spongy crust");
}