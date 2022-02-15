namespace FactoryMethod;

public abstract class PizzaStore
{
  public Pizza OrderPizza(string type)
  {
    var order = CreatePizza(type);

    order.Prepare();
    order.Bake();
    order.Cut();
    order.Box();

    return order;
  }

  public abstract Pizza CreatePizza(string type);
}