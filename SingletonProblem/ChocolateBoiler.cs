namespace SingletonProblem;
public class ChocolateBoiler
{
  private bool _empty;
  private bool _boiled;

  public ChocolateBoiler()
  {
    _empty = true;
    _boiled = false;
  }

  public void Fill()
  {
    if (IsEmpty())
    {
      _empty = false;
      _boiled = false;
      // fill the boiler with a milk/chocolate mixture
    }
  }

  public void Drain()
  {
    if (!IsEmpty() && IsBoiled())
    {
      // drain the boiled milk and chocolate
      _boiled = true;
    }
  }

  public void Boil()
  {
    if (!IsEmpty() && !IsBoiled())
    {
      // bring the contents to boil
      _boiled = true;
    }
  }

  private bool IsEmpty() => _empty;

  private bool IsBoiled() => _boiled;
}
