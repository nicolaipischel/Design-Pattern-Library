using System;
using Observer.Abstractions;

namespace Observer.Implementations
{
  public class CurrentConditionsDisplay : IObserver, IDisplay
  {
    private float _humidity;
    private float _temperature;

    public CurrentConditionsDisplay(IObservable subject) => subject.RegisterObserver(this);

    public void Update(float humidity, float temperature, int windSpeed)
    {
      _humidity = humidity;
      _temperature = temperature;

      Display();
    }

    public void Display() => Console.WriteLine($"Current conditions: Temperature {_temperature}°C and {_humidity}% humidity");
  }
}