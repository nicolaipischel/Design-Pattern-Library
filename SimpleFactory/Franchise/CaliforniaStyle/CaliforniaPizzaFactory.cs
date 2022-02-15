namespace SimpleFactory.Franchise.CaliforniaStyle;

public class CaliforniaPizzaFactory : PizzaFactory
{
  public override Pizza CreatePizza(string type)
  {
    Pizza pizza = null;

    if (type.Equals("cheese", StringComparison.InvariantCultureIgnoreCase)) pizza = new CaliforniaStyleCheesePizza();
    if (type.Equals("greek", StringComparison.InvariantCultureIgnoreCase)) pizza = new CaliforniaStyleGreekPizza();
    if (type.Equals("pepperoni", StringComparison.InvariantCultureIgnoreCase)) pizza = new CaliforniaStylePepperoniPizza();
    if (type.Equals("clam", StringComparison.InvariantCultureIgnoreCase)) pizza = new CaliforniaStyleClamPizza();
    if (type.Equals("veggie", StringComparison.InvariantCultureIgnoreCase)) pizza = new CaliforniaStyleVeggiePizza();

    return pizza;
  }
}