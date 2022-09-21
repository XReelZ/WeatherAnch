using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherForecast.Server.Models
{
    public class CityViewModel
    {
        public int CityID { get; set; }
        public string Name { get; set; }
        public string PostCode { get; set; }
        public ICollection<WeatherViewModel> Forecast { get; set; }
    }
}
