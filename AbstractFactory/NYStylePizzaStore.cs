using AbstractFactory.NYStyle;

namespace AbstractFactory;

public class NYStylePizzaStore : PizzaStore
{
  public NYStylePizzaStore(IPizzaIngredientFactory ingredientFactory) => _ingredientFactory = ingredientFactory;

  private readonly IPizzaIngredientFactory _ingredientFactory;
  public override Pizza CreatePizza(string type)
  {
    Pizza pizza = null;

    if (type.Equals("cheese", StringComparison.InvariantCultureIgnoreCase)) pizza = new NYStyleCheesePizza(_ingredientFactory);
    if (type.Equals("greek", StringComparison.InvariantCultureIgnoreCase)) pizza = new NYStyleGreekPizza(_ingredientFactory);
    if (type.Equals("pepperoni", StringComparison.InvariantCultureIgnoreCase)) pizza = new NYStylePepperoniPizza(_ingredientFactory);
    if (type.Equals("clam", StringComparison.InvariantCultureIgnoreCase)) pizza = new NYStyleClamPizza(_ingredientFactory);
    if (type.Equals("veggie", StringComparison.InvariantCultureIgnoreCase)) pizza = new NYStyleClamPizza(_ingredientFactory);

    return pizza;
  }
}
