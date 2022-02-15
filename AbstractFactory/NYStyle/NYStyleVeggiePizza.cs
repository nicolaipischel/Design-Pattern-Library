namespace AbstractFactory.NYStyle;

public class NYStyleVeggiePizza : Pizza
{
  private readonly IPizzaIngredientFactory _ingredientFactory;

  public NYStyleVeggiePizza(IPizzaIngredientFactory ingredientFactory)
  {
    _ingredientFactory = ingredientFactory;
    Name = "NY Style Sauce and Veggie Pizza";
  }

  public override void Prepare()
  {
    Console.WriteLine($"Preparing {Name}");
    Dough = _ingredientFactory.CreateDough();
    Sauce = _ingredientFactory.CreateSauce();
    Cheese = _ingredientFactory.CreateCheese();
    Veggies = _ingredientFactory.CreateVeggies();

    //Console.WriteLine("Pizza is being prepared with tasty sauce, fresh avocados, goat cheese and artichokes hearts");
  }
  public override void Bake() => Console.WriteLine("Pizza is being baked with a thin crust");

  public override void Box() => Console.WriteLine("Pizza is packaged in 3rd party box");
}