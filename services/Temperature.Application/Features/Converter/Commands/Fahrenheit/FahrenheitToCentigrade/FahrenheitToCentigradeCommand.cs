using System;
using MediatR;

namespace Temperature.Application.Features.Converter.Commands.Fahrenheit.FahrenheitToCentigrade
{
    public class FahrenheitToCentigradeCommand : IRequest<CentigradeDto>
    {
        public double Request { get; set; }

        public FahrenheitToCentigradeCommand(double request)
        {
            Request = request;
        }
    }
}
