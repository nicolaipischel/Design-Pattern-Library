namespace SimpleFactory.Franchise.ChicagoStyle;

public class ChicagoStyleClamPizza : Pizza
{
  public override void Prepare() =>
    Console.WriteLine("Pizza is being prepared with rich sauce, fresh clams, grated pecorino cheese, and olive oil");

  public override void Bake() => Console.WriteLine("Pizza is being baked in a deep metal pan with a thick high crust");
}