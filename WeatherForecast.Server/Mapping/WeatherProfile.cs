using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherForecast.Business.Models;
using WeatherForecast.Server.Models;

namespace WeatherForecast.Server.Mapping
{
    public class WeatherProfile : Profile
    {
        public WeatherProfile()
        {
            CreateMap<WeatherDto, WeatherViewModel>()
            .ForMember(dest =>
                dest.City,
                opt => opt.MapFrom(src => src.City.Name))
            .ReverseMap();
        }
    }
}
