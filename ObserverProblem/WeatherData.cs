namespace ObserverProblem;
public class WeatherData
{
  private readonly CurrentConditionsDisplay _currentConditionsDisplay;
  private readonly StatisticsDisplay _statisticsDisplay;
  private readonly ForecastDisplay _forecastDisplay;

  public WeatherData(
    float temperature,
    float humidity,
    int windSpeed,
    CurrentConditionsDisplay currentConditionsDisplay,
    StatisticsDisplay statisticsDisplay,
    ForecastDisplay forecastDisplay
    )
  {
    _currentConditionsDisplay = currentConditionsDisplay;
    _statisticsDisplay = statisticsDisplay;
    _forecastDisplay = forecastDisplay;
    Temperature = temperature;
    Humidity = humidity;
    WindSpeed = windSpeed;
  }

  public float Temperature { get; }
  public float Humidity { get; }
  public int WindSpeed { get; }

  public void MeasurementsChanged()
  {
    var temp = Temperature;
    var humidity = Humidity;
    var windSpeed = WindSpeed;

    _currentConditionsDisplay.Update(humidity, temp, windSpeed);
    _statisticsDisplay.Update(humidity, temp, windSpeed);
    _forecastDisplay.Update(humidity, temp, windSpeed);
  }
}
