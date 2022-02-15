namespace FactoryProblem;

public class PizzaStore
{
  public Pizza OrderPizza(string type)
  {
    Pizza order;

    if (type.Equals("cheese")) order = new CheesePizza();
    else if (type.Equals("greek")) order = new GreekPizza();
    else if (type.Equals("pepperoni")) order = new PepperoniPizza();
    else if (type.Equals("clam")) order = new ClamPizza();
    else if (type.Equals("veggie")) order = new VeggiePizza();
    else order = new Pizza();

    order.Prepare();
    order.Bake();
    order.Cut();
    order.Box();

    return order;
  }
}