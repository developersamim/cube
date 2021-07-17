using System;
using MediatR;

namespace Temperature.Application.Features.Converter.Commands.FahrenheitToCentigrade
{
    public class FahrenheitToCentigradeCommand : IRequest<double>
    {
        public double Request { get; set; }

        public FahrenheitToCentigradeCommand(double request)
        {
            Request = request;
        }
    }
}
