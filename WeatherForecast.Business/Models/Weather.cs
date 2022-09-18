using System;

namespace WeatherForecast.Business.Models
{
  public class Weather
  {

    public int ID { get; set; }
    public DateTime Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF { get; set; }

    public string Summary { get; set; }
  }
}
