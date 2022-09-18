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

        public IQueryable<Weather> GetForecast()
        {
            var res = this.context.WeatherForecasts
                .Select(w => w);
            return res;
        }
    }
}
