namespace SimpleFactory.Franchise.ChicagoStyle;

public class ChicagoStylePepperoniPizza : Pizza
{
  public override void Prepare() =>
    Console.WriteLine("Pizza is being prepared with rich sauce, fresh mozzarella and spicy pepperoni salami");

  public override void Bake() => Console.WriteLine("Pizza is being baked in a deep metal pan with a thick high crust");
}