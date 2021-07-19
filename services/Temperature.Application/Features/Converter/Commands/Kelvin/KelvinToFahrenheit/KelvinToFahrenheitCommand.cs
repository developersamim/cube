using System;
using MediatR;

namespace Temperature.Application.Features.Converter.Commands.Kelvin.KelvinToFahrenheit
{
    public class KelvinToFahrenheitCommand : IRequest<FahrenheitDto>
    {
        public double Request { get; set; }

        public KelvinToFahrenheitCommand(double request)
        {
            Request = request;
        }
    }
}
