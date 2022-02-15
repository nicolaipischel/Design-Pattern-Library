namespace SimpleFactory.Franchise.ChicagoStyle;

public class ChicagoStyleCheesePizza : Pizza
{
  public override void Prepare() =>
    Console.WriteLine("Pizza is being prepared with rich sauce and tons of cheese");

  public override void Bake() => Console.WriteLine("Pizza is being baked in a deep metal pan with a thick high crust");
}