namespace AbstractFactory.NYStyle;

public class NYStyleCheesePizza : Pizza
{
  private readonly IPizzaIngredientFactory _ingredientFactory;

  public NYStyleCheesePizza(IPizzaIngredientFactory ingredientFactory)
  {
    _ingredientFactory = ingredientFactory;
    Name = "NY Style Sauce and Cheese Pizza";
  }

  public override void Prepare()
  {
    Console.WriteLine($"Preparing {Name}");
    Dough = _ingredientFactory.CreateDough();
    Sauce = _ingredientFactory.CreateSauce();
    Cheese = _ingredientFactory.CreateCheese();
  }
}