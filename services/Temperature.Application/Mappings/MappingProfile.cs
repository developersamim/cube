using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Temperature.Application.Features.Converter.Commands.Centigrade.CentigradeToFahrenheit;
using Temperature.Application.Features.Converter.Commands.Centigrade.CentigradeToKelvin;
using Temperature.Application.Features.Converter.Commands.Fahrenheit.FahrenheitToCentigrade;
using Temperature.Core.Entities;

namespace Temperature.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Fahrenheit, FahrenheitDto>();
            CreateMap<Kelvin, KelvinDto>();
            CreateMap<Kelvin, Features.Converter.Commands.Fahrenheit.FahrenheitToKelvin.KelvinDto>();
            CreateMap<Centigrade, CentigradeDto>();
            CreateMap<Centigrade, Features.Converter.Commands.Kelvin.KelvinToCentigrade.CentigradeDto>();
            CreateMap<FahrenheitDto, Features.Converter.Commands.Kelvin.KelvinToFahrenheit.FahrenheitDto>();
        }
    }
}
