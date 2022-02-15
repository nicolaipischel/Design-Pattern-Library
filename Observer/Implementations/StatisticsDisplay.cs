using System;
using System.Collections.Generic;
using System.Linq;
using Observer.Abstractions;

namespace Observer.Implementations
{
  public class StatisticsDisplay : IObserver, IDisplay
  {
    private readonly List<float> _temperatureHistory = new();

    public StatisticsDisplay(IObservable subject) => subject.RegisterObserver(this);

    public void Update(float humidity, float temperature, int windSpeed)
    {
      _temperatureHistory.Add(temperature);

      Display();
    }

    public void Display()
    {
      Console.WriteLine(
        $"Avg/Max/Min temperature = {_temperatureHistory.Average()}/{_temperatureHistory.Max()}/{_temperatureHistory.Min()}");
    }
  }
}