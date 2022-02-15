using System.Collections.Generic;
using Observer.Abstractions;

namespace Observer.Implementations
{
  public class WeatherData : IObservable
  {
    private readonly List<IObserver> _observers;
    private float _temperature;
    private float _humidity;
    private int _windSpeed;

    public void RegisterObserver(IObserver observer) => _observers.Add(observer);

    public void RemoveObserver(IObserver observer) => _observers.Remove(observer);

    public void NotifyObservers()
    {
      foreach (var observer in _observers)
      {
        observer.Update(_temperature, _humidity, _windSpeed);
      }
    }

    public void SetMeasurements(float temperature, float humidity, int windSpeed)
    {
      _temperature = temperature;
      _humidity = humidity;
      _windSpeed = windSpeed;

      NotifyObservers();
    }
  }
}