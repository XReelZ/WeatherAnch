using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WeatherForecast.Business.Models;

namespace WeatherForecast.Business.Data
{
  public class ForecastDbContext : DbContext
  {
    public ForecastDbContext(DbContextOptions<ForecastDbContext> options): base(options)
    {
      
    }

    public DbSet<City> Cities { get; set; }
    public DbSet<Weather> WeatherForecasts { get; set; }
  }
}
