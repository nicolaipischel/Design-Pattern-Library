namespace FactoryMethod;
public abstract class Pizza
{
  public string Name { get; protected set; }
  public string Dough { get; protected set; }
  public string Sauce { get; protected set; }
  public List<string> Toppings { get; protected set; }

  public virtual void Prepare()
  {
    Console.WriteLine($"Preparing {Name} ...");
    Console.WriteLine($"Tossing {Dough} ...");
    Console.WriteLine($"Adding {Sauce} ...");
    Console.WriteLine($"Adding toppings: {string.Join(' ', Toppings)}");
  }
  public virtual void Bake() => Console.WriteLine("Bake for 25 minutes at 350° in the oven");
  public virtual void Cut() => Console.WriteLine("Cutting the pizza into diagonal slices");
  public virtual void Box() => Console.WriteLine("Place pizza in official PizzaStore box");
}
