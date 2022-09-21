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

        public DbSet<CityDto> Cities { get; set; }
        public DbSet<WeatherDto> WeatherForecasts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CityDto>(e =>
            {
                e.HasKey(k => k.CityID)
                .HasName("PK_City");
            });

            modelBuilder.Entity<WeatherDto>(w =>
            {
                w.HasKey(k => k.WeatherID)
                .HasName("PK_Weather");
            });

            modelBuilder.Entity<CityDto>()
                .HasMany(c => c.Forecast)
                .WithOne(w => w.City);

            modelBuilder.Entity<WeatherDto>().HasData(
            new WeatherDto
            {
                WeatherID = 1,
                CityID = 1,
                Date = new DateTime(2022, 08, 10),
                Summary = "Very Hot",
                TemperatureC = 30,
                TemperatureF = (30 * 9) / 5 + 32
            });

            modelBuilder.Entity<CityDto>().HasData(
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
