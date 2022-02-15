namespace ObserverProblem;

public class StatisticsDisplay
{
  private readonly List<float> _temperatureHistory = new();

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