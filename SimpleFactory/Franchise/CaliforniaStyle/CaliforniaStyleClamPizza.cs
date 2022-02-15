namespace SimpleFactory.Franchise.CaliforniaStyle;

public class CaliforniaStyleClamPizza : Pizza
{
  public override void Prepare() =>
    Console.WriteLine("Pizza is being prepared with tasty sauce, the freshest local clams, grated pecorino cheese, and olive oil");

  public override void Bake() => Console.WriteLine("Pizza is being baked in the restaurants coal-fired pizza oven with a thin crust");
}