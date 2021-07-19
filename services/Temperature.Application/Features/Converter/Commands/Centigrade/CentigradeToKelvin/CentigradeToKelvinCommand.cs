using System;
using MediatR;

namespace Temperature.Application.Features.Converter.Commands.Centigrade.CentigradeToKelvin
{
    public class CentigradeToKelvinCommand : IRequest<KelvinDto>
    {
        public double Request { get; set; }

        public CentigradeToKelvinCommand(double request)
        {
            Request = request;
        }
    }
}
