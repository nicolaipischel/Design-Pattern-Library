namespace AbstractFactory.ChicagoStyle;

public class ChicagoStyleGreekPizza : Pizza
{
  private readonly IPizzaIngredientFactory _ingredientFactory;

  public ChicagoStyleGreekPizza(IPizzaIngredientFactory ingredientFactory)
  {
    _ingredientFactory = ingredientFactory;
    _ingredientFactory = ingredientFactory;
    Name = "Chicago Style Deep Dish Greek Pizza";
  }

  public override void Prepare()
  {
    Console.WriteLine($"Preparing {Name}");
    Dough = _ingredientFactory.CreateDough();
    Sauce = _ingredientFactory.CreateSauce();
    Cheese = _ingredientFactory.CreateCheese();
    Veggies = _ingredientFactory.CreateVeggies();

    //Console.WriteLine("Pizza is being prepared with rich sauce, fresh feta, onion, olives and tomato");
  }

  public override void Bake() => Console.WriteLine("Pizza is being baked in a deep metal pan with a thick spongy crust");
}