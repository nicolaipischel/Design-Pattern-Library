using AbstractFactory.ChicagoStyle;

namespace AbstractFactory;

public class ChicagoStylePizzaStore : PizzaStore
{
  public ChicagoStylePizzaStore(IPizzaIngredientFactory ingredientFactory) => _ingredientFactory = ingredientFactory;

  private readonly IPizzaIngredientFactory _ingredientFactory;

  public override Pizza CreatePizza(string type)
  {
    Pizza pizza = null;

    if (type.Equals("cheese", StringComparison.InvariantCultureIgnoreCase)) pizza = new ChicagoStyleCheesePizza(_ingredientFactory);
    if (type.Equals("greek", StringComparison.InvariantCultureIgnoreCase)) pizza = new ChicagoStyleGreekPizza(_ingredientFactory);
    if (type.Equals("pepperoni", StringComparison.InvariantCultureIgnoreCase)) pizza = new ChicagoStylePepperoniPizza(_ingredientFactory);
    if (type.Equals("clam", StringComparison.InvariantCultureIgnoreCase)) pizza = new ChicagoStyleClamPizza(_ingredientFactory);
    if (type.Equals("veggie", StringComparison.InvariantCultureIgnoreCase)) pizza = new ChicagoStyleVeggiePizza(_ingredientFactory);

    return pizza;
  }
}
