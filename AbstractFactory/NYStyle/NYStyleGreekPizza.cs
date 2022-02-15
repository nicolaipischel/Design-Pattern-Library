namespace AbstractFactory.NYStyle;

public class NYStyleGreekPizza : Pizza
{
  private readonly IPizzaIngredientFactory _ingredientFactory;

  public NYStyleGreekPizza(IPizzaIngredientFactory ingredientFactory)
  {
    _ingredientFactory = ingredientFactory;
    Name = "NY Style Sauce and Greek Pizza";
  }

  public override void Prepare()
  {
    Console.WriteLine($"Preparing {Name}");
    Dough = _ingredientFactory.CreateDough();
    Sauce = _ingredientFactory.CreateSauce();
    Cheese = _ingredientFactory.CreateCheese();
    Veggies = _ingredientFactory.CreateVeggies();

    //Console.WriteLine("Pizza is being prepared with tasty sauce, fresh feta, onion, olives and tomato");
  }

  public override void Bake() => Console.WriteLine("Pizza is being baked in a shallow metal pan with a thin spongy crust");

  public override void Box() => Console.WriteLine("Pizza is packaged in 3rd party box");
}