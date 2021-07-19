using System;
using MediatR;

namespace Temperature.Application.Features.Converter.Commands.Centigrade.CentigradeToFahrenheit
{
    public class CentigradeToFahrenheitCommand : IRequest<FahrenheitDto>
    {
       public double Request { get; set; }

        public CentigradeToFahrenheitCommand(double request)
        {
            Request = request;
        }
    }
}
