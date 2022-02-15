namespace SimpleFactory;

public class PizzaStore
{
  private readonly PizzaFactory _factory;

  public PizzaStore(PizzaFactory factory) => _factory = factory;
  public Pizza OrderPizza(string type)
  {
    var order = _factory.CreatePizza(type);

    order.Prepare();
    order.Bake();
    order.Cut();
    order.Box();

    return order;
  }
}