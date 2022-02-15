namespace Observer.Abstractions
{
  public interface IObserver
  {
    void Update(float temperature, float humidity, int windSpeed);
  }
}