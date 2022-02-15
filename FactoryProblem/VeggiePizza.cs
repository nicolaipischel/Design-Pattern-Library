namespace SimpleFactory.Franchise.NYStyle;

public class NYStyleVeggiePizza : Pizza
{
  public override void Prepare() =>
    Console.WriteLine("Pizza is being prepared with tasty sauce, fresh avocados, goat cheese and artichokes hearts");

  public override void Bake() => Console.WriteLine("Pizza is being baked with a thin crust");

  public override void Box() => Console.WriteLine("Pizza is packaged in 3rd party box");
}