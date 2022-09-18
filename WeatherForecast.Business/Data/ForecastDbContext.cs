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
        public ForecastDbContext(DbContextOptions<ForecastDbContext> options) : base(options)
        {
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Weather> WeatherForecasts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>(e =>
            {
                e.HasKey(k => k.CityID)
                .HasName("PK_City");
            });

            modelBuilder.Entity<Weather>(w =>
            {
                w.HasKey(k => k.WeatherID)
                .HasName("PK_Weather");
            });

            modelBuilder.Entity<City>()
                .HasMany(c => c.Forecast)
                .WithOne(w => w.City);

            modelBuilder.Entity<Weather>().HasData(
            new Weather
            {
                WeatherID = 1,
                CityID = 1,
                Date = new DateTime(2022, 08, 10),
                Summary = "Very Hot",
                TemperatureC = 30,
                TemperatureF = (30 * 9) / 5 + 32
            });

            modelBuilder.Entity<City>().HasData(
                // anonymous type
                new
                {
                    CityID = 1,
                    WeatherID = 1,
                    Name = "Sofia",
                    PostCode = "1000"
                });

        }
    }
}
