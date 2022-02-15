using AbstractFactory.Ingredients;
using AbstractFactory.Ingredients.Interfaces;

namespace AbstractFactory.NYStyle;

public class NYPizzaIngredientFactory : IPizzaIngredientFactory
{
  public Dough CreateDough() => new ThinCrustDough();

  public Sauce CreateSauce() => new MarinaraSauce();

  public Cheese CreateCheese() => new ReggianoCheese();

  public Veggie[] CreateVeggies() => new Veggie[] { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };

  public Pepperoni CreatePepperoni() => new SlicedPepperoni();

  public Clam CreateClams() => new FreshClams();
}