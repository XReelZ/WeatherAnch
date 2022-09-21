using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast.Business.Models
{
    public class CityDto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CityID { get; set; }
        public string Name { get; set; }
        public string PostCode { get; set; }
        public ICollection<WeatherDto> Forecast { get; set; }
    }
}
