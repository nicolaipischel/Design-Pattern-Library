namespace AbstractFactory.ChicagoStyle;

public class ChicagoStyleVeggiePizza : Pizza
{
  private readonly IPizzaIngredientFactory _ingredientFactory;

  public ChicagoStyleVeggiePizza(IPizzaIngredientFactory ingredientFactory)
  {
    _ingredientFactory = ingredientFactory;
    Name = "Chicago Style Deep Dish Veggie Pizza";
  }

  public override void Prepare()
  {
    Console.WriteLine($"Preparing {Name}");
    Dough = _ingredientFactory.CreateDough();
    Sauce = _ingredientFactory.CreateSauce();
    Cheese = _ingredientFactory.CreateCheese();
    Veggies = _ingredientFactory.CreateVeggies();

    //Console.WriteLine("Pizza is being prepared with rich sauce, mozarella and vegetables");
  }

  public override void Bake() => Console.WriteLine("Pizza is being baked in a deep metal pan with a thick high crust");
}