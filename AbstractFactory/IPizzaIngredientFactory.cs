using AbstractFactory.Ingredients.Interfaces;

namespace AbstractFactory;

public interface IPizzaIngredientFactory
{
  public Dough CreateDough();
  public Sauce CreateSauce();
  public Cheese CreateCheese();
  public Veggie[] CreateVeggies();
  public Pepperoni CreatePepperoni();
  public Clam CreateClams();
}