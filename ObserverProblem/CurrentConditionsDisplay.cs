namespace ObserverProblem;

public class CurrentConditionsDisplay
{
  private float _humidity;
  private float _temperature;

  public void Update(float humidity, float temperature, int windSpeed)
  {
    _humidity = humidity;
    _temperature = temperature;

    Display();
  }

  public void Display() => Console.WriteLine($"Current conditions: Temperature {_temperature}° C and {_humidity}% humidity");
}