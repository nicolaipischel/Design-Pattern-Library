namespace SimpleFactory.Franchise.NYStyle;

public class NYStylePepperoniPizza : Pizza
{
  public override void Prepare() =>
    Console.WriteLine("Pizza is being prepared with tasty sauce, fresh mozzarella and the spicy pepperoni salami");

  public override void Bake() => Console.WriteLine("Pizza is being baked with a thin crust");

  public override void Box() => Console.WriteLine("Pizza is packaged in 3rd party box");
}