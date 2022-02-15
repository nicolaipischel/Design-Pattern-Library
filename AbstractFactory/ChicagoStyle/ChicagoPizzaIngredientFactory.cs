using AbstractFactory.Ingredients;
using AbstractFactory.Ingredients.Interfaces;

namespace AbstractFactory.ChicagoStyle;

public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
{
  public Dough CreateDough() => new ThickCrustDough();

  public Sauce CreateSauce() => new PlumTomatoSauce();

  public Cheese CreateCheese() => new MozzarellaCheese();

  public Veggie[] CreateVeggies() => new Veggie[] { new Spinach(), new BlackOlives(), new EggPlant() };

  public Pepperoni CreatePepperoni() => new SlicedPepperoni();

  public Clam CreateClams() => new FrozenClams();
}