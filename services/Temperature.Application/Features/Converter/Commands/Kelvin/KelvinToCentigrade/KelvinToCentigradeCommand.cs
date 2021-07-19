using System;
using MediatR;

namespace Temperature.Application.Features.Converter.Commands.Kelvin.KelvinToCentigrade
{
    public class KelvinToCentigradeCommand : IRequest<CentigradeDto>
    {
        public double Request { get; set; }

        public KelvinToCentigradeCommand(double request)
        {
            Request = request;
        }
    }
}
