namespace SimpleFactory.Franchise.ChicagoStyle;

public class ChicagoStyleVeggiePizza : Pizza
{
  public override void Prepare() =>
    Console.WriteLine("Pizza is being prepared with rich sauce, mozarella and vegetables");

  public override void Bake() => Console.WriteLine("Pizza is being baked in a deep metal pan with a thick high crust");
}