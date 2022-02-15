namespace AbstractFactory.ChicagoStyle;

public class ChicagoStyleCheesePizza : Pizza
{
  private readonly IPizzaIngredientFactory _ingredientFactory;

  public ChicagoStyleCheesePizza(IPizzaIngredientFactory ingredientFactory)
  {
    _ingredientFactory = ingredientFactory;
    Name = "Chicago Style Deep Dish Cheese Pizza";
  }

  public override void Prepare()
  {
    Console.WriteLine($"Preparing {Name}");
    Dough = _ingredientFactory.CreateDough();
    Sauce = _ingredientFactory.CreateSauce();
    Cheese = _ingredientFactory.CreateCheese();
  }

  public override void Bake() => Console.WriteLine("Bake for 25 minutes at 350° in a deep metal pan");

  public override void Cut() => Console.WriteLine("Cutting the pizza into square slices");
}