using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherForecast.Server.Models
{
    public class WeatherViewModel
    {
        public int WeatherID { get; set; }
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF { get; set; }

        public string Summary { get; set; }

        public int CityID { get; set; }

        public string City { get; set; }
    }
}
