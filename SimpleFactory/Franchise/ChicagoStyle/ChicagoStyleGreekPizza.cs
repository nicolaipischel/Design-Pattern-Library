namespace SimpleFactory.Franchise.ChicagoStyle;

public class ChicagoStyleGreekPizza : Pizza
{
  public override void Prepare() =>
    Console.WriteLine("Pizza is being prepared with rich sauce, fresh feta, onion, olives and tomato");

  public override void Bake() => Console.WriteLine("Pizza is being baked in a deep metal pan with a thick spongy crust");
}