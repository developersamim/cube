using System;
using MediatR;

namespace Temperature.Application.Features.Converter.Commands.CentigradeToFahrenheit
{
    public class CentigradeToFahrenheitCommand : IRequest<double>
    {
       public double Request { get; set; }

        public CentigradeToFahrenheitCommand(double request)
        {
            Request = request;
        }
    }
}
