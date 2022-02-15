namespace FactoryMethod.CaliforniaStyle;

public class CaliforniaStyleCheesePizza : Pizza
{
  public override void Prepare() =>
    Console.WriteLine("Pizza is being prepared with tasty sauce and just a little cheese");

  public override void Bake() => Console.WriteLine("Pizza is being baked with a thin crust");
}