using System;
using MediatR;

namespace Temperature.Application.Features.Converter.Commands.KelvinToFahrenheit
{
    public class KelvinToFahrenheitCommand : IRequest<double>
    {
        public double Request { get; set; }

        public KelvinToFahrenheitCommand(double request)
        {
            Request = request;
        }
    }
}
