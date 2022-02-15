namespace StrategyProblem;

public class RubberDuck : Duck
{
  public override void Display() => Console.WriteLine("Looks like a rubber duck");
  public override void Quack() => Console.WriteLine("Squeak!");
  public override void Fly() { }
}