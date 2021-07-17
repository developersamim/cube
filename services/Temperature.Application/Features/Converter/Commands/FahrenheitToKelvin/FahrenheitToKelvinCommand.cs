using System;
using MediatR;

namespace Temperature.Application.Features.Converter.Commands.FahrenheitToKelvin
{
    public class FahrenheitToKelvinCommand : IRequest<double>
    {
        public double Request { get; set; }

        public FahrenheitToKelvinCommand(double request)
        {
            Request = request;
        }
    }
}
