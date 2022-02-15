namespace FactoryMethod.CaliforniaStyle;

public class CaliforniaStyleVeggiePizza : Pizza
{
  public override void Prepare() =>
    Console.WriteLine("Pizza is being prepared with tasty sauce, the freshest local avocados, goat cheese and artichokes hearts");

  public override void Bake() => Console.WriteLine("Pizza is being baked with a thin crust");
}