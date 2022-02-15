namespace AbstractFactory.ChicagoStyle;

public class ChicagoStylePepperoniPizza : Pizza
{
  private readonly IPizzaIngredientFactory _ingredientFactory;

  public ChicagoStylePepperoniPizza(IPizzaIngredientFactory ingredientFactory)
  {
    _ingredientFactory = ingredientFactory;
    Name = "Chicago Style Deep Dish Pepperoni Pizza";
  }
  public override void Prepare()
  {
    Console.WriteLine($"Preparing {Name}");
    Dough = _ingredientFactory.CreateDough();
    Sauce = _ingredientFactory.CreateSauce();
    Cheese = _ingredientFactory.CreateCheese();
    Pepperoni = _ingredientFactory.CreatePepperoni();

    //Console.WriteLine("Pizza is being prepared with rich sauce, fresh mozzarella and spicy pepperoni salami");
  }

  public override void Bake() => Console.WriteLine("Pizza is being baked in a deep metal pan with a thick high crust");
}