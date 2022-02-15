namespace StrategyProblem;
public class Duck
{
  public virtual void Quack() => Console.WriteLine("Quack!");

  public virtual void Swim() => Console.WriteLine("I'm swimming!");

  public virtual void Display() => Console.WriteLine("Looks like a duck!");

  public virtual void Fly() => Console.WriteLine("I'm flying!");
}
