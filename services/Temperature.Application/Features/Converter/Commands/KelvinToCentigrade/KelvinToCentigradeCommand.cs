using System;
using MediatR;

namespace Temperature.Application.Features.Converter.Commands.KelvinToCentigrade
{
    public class KelvinToCentigradeCommand : IRequest<double>
    {
        public double Request { get; set; }

        public KelvinToCentigradeCommand(double request)
        {
            Request = request;
        }
    }
}
