namespace SimpleFactory.Franchise.CaliforniaStyle;

public class CaliforniaStylePepperoniPizza : Pizza
{
  public override void Prepare() =>
    Console.WriteLine(
      "Pizza is being prepared with tasty sauce and fresh mozzarella and the finest well spiced pepperoni salami");

  public override void Bake() => Console.WriteLine("Pizza is being baked with a thin crust");
}