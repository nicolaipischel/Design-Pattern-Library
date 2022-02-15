namespace AbstractFactory.ChicagoStyle;

public class ChicagoStyleClamPizza : Pizza
{
  private readonly IPizzaIngredientFactory _ingredientFactory;

  public ChicagoStyleClamPizza(IPizzaIngredientFactory ingredientFactory)
  {
    _ingredientFactory = ingredientFactory;
    Name = "Chicago Style Deep Dish Clam Pizza";
  }
  public override void Prepare()
  {
    Console.WriteLine($"Preparing {Name}");
    Dough = _ingredientFactory.CreateDough();
    Sauce = _ingredientFactory.CreateSauce();
    Cheese = _ingredientFactory.CreateCheese();
    Clam = _ingredientFactory.CreateClams();

    //Console.WriteLine("Pizza is being prepared with rich sauce, fresh clams, grated pecorino cheese, and olive oil");
  }

  public override void Bake() => Console.WriteLine("Pizza is being baked in a deep metal pan");
}