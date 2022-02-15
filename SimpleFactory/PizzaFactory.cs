namespace SimpleFactory;

public abstract class PizzaFactory
{
  public abstract Pizza CreatePizza(string type);
}