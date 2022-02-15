namespace SimpleFactory.Franchise.NYStyle;

public class NYPizzaFactory : PizzaFactory
{
  public override Pizza CreatePizza(string type)
  {
    Pizza pizza = null;

    if (type.Equals("cheese", StringComparison.InvariantCultureIgnoreCase)) pizza = new NYStyleCheesePizza();
    if (type.Equals("greek", StringComparison.InvariantCultureIgnoreCase)) pizza = new NYStyleGreekPizza();
    if (type.Equals("pepperoni", StringComparison.InvariantCultureIgnoreCase)) pizza = new NYStylePepperoniPizza();
    if (type.Equals("clam", StringComparison.InvariantCultureIgnoreCase)) pizza = new NYStyleClamPizza();
    if (type.Equals("veggie", StringComparison.InvariantCultureIgnoreCase)) pizza = new NYStyleClamPizza();

    return pizza;
  }
}