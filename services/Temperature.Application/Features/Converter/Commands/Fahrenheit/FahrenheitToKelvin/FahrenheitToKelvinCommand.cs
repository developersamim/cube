using System;
using MediatR;

namespace Temperature.Application.Features.Converter.Commands.Fahrenheit.FahrenheitToKelvin
{
    public class FahrenheitToKelvinCommand : IRequest<KelvinDto>
    {
        public double Request { get; set; }

        public FahrenheitToKelvinCommand(double request)
        {
            Request = request;
        }
    }
}
