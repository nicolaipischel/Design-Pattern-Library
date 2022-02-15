namespace FactoryMethod.ChicagoStyle;

public class ChicagoStyleCheesePizza : Pizza
{
  public ChicagoStyleCheesePizza()
  {
    Name = "Chicago Style Deep Dish Cheese Pizza";
    Dough = "Extra Thick Crust Dough";
    Sauce = "Plum Tomato Sauce";

    Toppings.Add("Shredded Mozzarella Cheese");
  }

  public override void Bake() => Console.WriteLine("Bake for 25 minutes at 350° in a deep metal pan");

  public override void Cut() => Console.WriteLine("Cutting the pizza into square slices");
}