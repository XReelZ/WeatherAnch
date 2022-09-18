using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForecast.Business.Models;

namespace WeatherForecast.Business
{
    public interface IDataManager
    {
        public IQueryable<Weather> GetForecast();
    }
}
