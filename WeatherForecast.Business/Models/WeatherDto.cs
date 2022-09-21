using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeatherForecast.Business.Models
{
    public class WeatherDto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WeatherID { get; set; }

        public DateTime Date { get; set; }

        public int TemperatureMin { get; set; }

        public int TemperatureMax { get; set; }

        public float RainChancePerc { get; set; }

        public int CityID { get; set; }

        public CityDto City { get; set; }
    }
}
