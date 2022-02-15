using AbstractFactory.Ingredients.Interfaces;

namespace AbstractFactory.Ingredients;

public class Onion : Veggie
{
  public override string ToString() => nameof(Onion);
}