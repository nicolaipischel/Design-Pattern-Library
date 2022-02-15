using AbstractFactory.Ingredients.Interfaces;

namespace AbstractFactory;
public abstract class Pizza
{
  public string Name { get; protected set; }
  public Dough Dough { get; protected set; }
  public Sauce Sauce { get; protected set; }
  public Veggie[] Veggies { get; protected set; }
  public Cheese Cheese { get; protected set; }
  public Pepperoni Pepperoni { get; protected set; }
  public Clam Clam { get; protected set; }
  //public List<string> Toppings { get; protected set; }

  public abstract void Prepare();
  //{
  //  Console.WriteLine($"Preparing {Name} ...");
  //  Console.WriteLine($"Tossing {Dough} ...");
  //  Console.WriteLine($"Adding {Sauce} ...");
  //  Console.WriteLine($"Adding toppings: {string.Join(' ', Toppings)}");
  //}
  public virtual void Bake() => Console.WriteLine("Bake for 25 minutes at 350° in the oven");
  public virtual void Cut() => Console.WriteLine("Cutting the pizza into diagonal slices");
  public virtual void Box() => Console.WriteLine("Place pizza in official PizzaStore box");
}
