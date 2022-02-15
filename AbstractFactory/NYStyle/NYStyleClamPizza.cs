namespace AbstractFactory.NYStyle;

public class NYStyleClamPizza : Pizza
{
  private readonly IPizzaIngredientFactory _ingredientFactory;

  public NYStyleClamPizza(IPizzaIngredientFactory ingredientFactory)
  {
    _ingredientFactory = ingredientFactory;
    Name = "NY Style Sauce and Clam Pizza";
  }

  public override void Prepare()
  {
    Console.WriteLine($"Preparing {Name}");
    Dough = _ingredientFactory.CreateDough();
    Sauce = _ingredientFactory.CreateSauce();
    Cheese = _ingredientFactory.CreateCheese();
    Clam = _ingredientFactory.CreateClams();

    //Console.WriteLine("Pizza is being prepared with tasty sauce, fresh clams, grated pecorino cheese, and olive oil");
  }

  public override void Bake() => Console.WriteLine("Pizza is being baked");

  public override void Box() => Console.WriteLine("Pizza is packaged in 3rd party box");
}