namespace SimpleFactory.Franchise.ChicagoStyle;

public class ChicagoPizzaFactory : PizzaFactory
{
  public override Pizza CreatePizza(string type)
  {
    Pizza pizza = null;

    if (type.Equals("cheese", StringComparison.InvariantCultureIgnoreCase)) pizza = new ChicagoStyleCheesePizza();
    if (type.Equals("greek", StringComparison.InvariantCultureIgnoreCase)) pizza = new ChicagoStyleGreekPizza();
    if (type.Equals("pepperoni", StringComparison.InvariantCultureIgnoreCase)) pizza = new ChicagoStylePepperoniPizza();
    if (type.Equals("clam", StringComparison.InvariantCultureIgnoreCase)) pizza = new ChicagoStyleClamPizza();
    if (type.Equals("veggie", StringComparison.InvariantCultureIgnoreCase)) pizza = new ChicagoStyleVeggiePizza();

    return pizza;
  }
}