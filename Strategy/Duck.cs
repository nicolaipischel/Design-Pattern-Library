using Strategy.Display;
using Strategy.Fly;
using Strategy.Quack;

namespace Strategy
{
  public record Duck
  {
    public IQuackStrategy QuackStrategy { get; init; }
    public IFlyStrategy FlyStrategy { get; init; }
    public IDisplayStrategy DisplayStrategy { get; init; }
  }
}