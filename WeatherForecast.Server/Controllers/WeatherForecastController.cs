using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherForecast.Business;
using WeatherForecast.Business.Models;
using WeatherForecast.Server.Models;

namespace WeatherForecast.Server.Controllers
{
    public class WeatherForecastController : ControllerBase
    {
        private readonly IDataManager _dm;
        private readonly IMapper _mapper;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IDataManager dm, IMapper mapper)
        {
            _logger = logger;
            _dm = dm;
            _mapper = mapper;
        }

        [Route("api/GetWeatherForecast")]
        [HttpGet]
        public ActionResult<IEnumerable<WeatherViewModel>> GetWeatherForecast(int cityId)
        {
            if(cityId <= 0)
                return this.BadRequest();
            //
            var res = _dm.GetForecast(cityId).Select(w => _mapper.Map<WeatherViewModel>(w));
            if(res.Any())
                return this.Ok(res);
            //
            return (this.NotFound());
        }
    }
}
