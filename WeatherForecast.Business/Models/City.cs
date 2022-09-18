using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast.Business.Models
{
  public class City
  {
    public int ID { get; set; }
    public string Name { get; set; }
    public int PostCode { get; set; }
    public List<Weather> Forecast { get; set; }
  }
}
