using AbstractFactory.Ingredients.Interfaces;

namespace AbstractFactory.Ingredients;

public class Garlic : Veggie
{
  public override string ToString() => nameof(Garlic);
}