namespace FactoryMethod.NYStyle;

public class NYStyleClamPizza : Pizza
{
  public override void Prepare() =>
    Console.WriteLine("Pizza is being prepared with tasty sauce, fresh clams, grated pecorino cheese, and olive oil");

  public override void Bake() => Console.WriteLine("Pizza is being baked with a thin crust");

  public override void Box() => Console.WriteLine("Pizza is packaged in 3rd party box");
}