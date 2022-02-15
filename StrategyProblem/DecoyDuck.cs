namespace StrategyProblem;

public class DecoyDuck : Duck
{
  public override void Quack() { }

  public override void Display() => Console.WriteLine("Looks like a wooden decoy duck");

  public override void Fly() { }
}