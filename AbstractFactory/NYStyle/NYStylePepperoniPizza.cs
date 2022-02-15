namespace AbstractFactory.NYStyle;

public class NYStylePepperoniPizza : Pizza
{
  private readonly IPizzaIngredientFactory _ingredientFactory;

  public NYStylePepperoniPizza(IPizzaIngredientFactory ingredientFactory)
  {
    _ingredientFactory = ingredientFactory;
    Name = "NY Style Sauce and Pepperoni Pizza";
  }

  public override void Prepare()
  {
    Console.WriteLine($"Preparing {Name}");
    Dough = _ingredientFactory.CreateDough();
    Sauce = _ingredientFactory.CreateSauce();
    Cheese = _ingredientFactory.CreateCheese();
    Pepperoni = _ingredientFactory.CreatePepperoni();

    //Console.WriteLine("Console.WriteLine("Pizza is being prepared with tasty sauce, fresh mozzarella and the spicy pepperoni salami");
  }

  public override void Bake() => Console.WriteLine("Pizza is being baked with a thin crust");

  public override void Box() => Console.WriteLine("Pizza is packaged in 3rd party box");
}