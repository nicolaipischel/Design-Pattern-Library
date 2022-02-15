using System;
using Observer.Abstractions;

namespace Observer.Implementations
{
  public class ForecastDisplay : IObserver, IDisplay
  {
    private float _pastHumidity;
    private float _futureHumidity;
    private float _pastTemperature;
    private float _futureTemperature;

    public ForecastDisplay(IObservable subject) => subject.RegisterObserver(this);

    public void Update(float humidity, float temperature, int windSpeed)
    {
      _pastHumidity = _futureHumidity;
      _pastTemperature = _futureTemperature;

      _futureHumidity = humidity;
      _futureTemperature = temperature;
    }

    public void Display()
    {
      if (_pastTemperature > _futureTemperature && _pastHumidity < _futureHumidity)
      {
        Console.WriteLine("Watch out for cooler, rainy weather");
      }
      else if (_pastTemperature > _futureTemperature)
      {
        Console.WriteLine("Watch out for cooler weather");
      }
      else if (_pastTemperature < _futureTemperature && _pastHumidity < _futureHumidity)
      {
        Console.WriteLine("Watch out for warmer, rainy weather");
      }
      else if (_pastTemperature < _futureTemperature && _pastHumidity > _futureHumidity)
      {
        Console.WriteLine("Improving weather on the way!");
      }
      else
      {
        Console.WriteLine("More of the same");
      }
    }
  }
}