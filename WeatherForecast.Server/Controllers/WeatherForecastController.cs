using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherForecast.Business;
using WeatherForecast.Business.Models;

namespace WeatherForecast.Server.Controllers
{
    public class WeatherForecastController : ControllerBase
    {
        private readonly IDataManager dm;

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IDataManager dm)
        {
            _logger = logger;
            this.dm = dm;
        }

        [Route("api/GetWeatherForecast")]
        [HttpGet]
        public ActionResult<IEnumerable<Weather>> Get()
        {
            var res = this.dm.GetForecast();

            return this.Ok(res);
        }
    }
}
