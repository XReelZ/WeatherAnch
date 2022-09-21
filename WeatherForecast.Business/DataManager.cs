using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForecast.Business.Data;
using WeatherForecast.Business.Models;

namespace WeatherForecast.Business
{
    public class DataManager : IDataManager
    {
        private readonly ForecastDbContext context;

        public DataManager(ForecastDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<WeatherDto> GetForecast(int cityID)
        {
            var res = this.context.WeatherForecasts
                .Where(w => w.CityID == cityID)
                .Include(w => w.City)
                .Select(w => w);
            return res;
        }
    }
}
