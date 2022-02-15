namespace Strategy.Fly
{
  public class NoFlying : IFlyStrategy
  {
    public void Fly() => throw new System.NotImplementedException();
  }
}