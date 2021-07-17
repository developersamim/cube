using System;
using MediatR;

namespace Temperature.Application.Features.Converter.Commands.CentigradeToKelvin
{
    public class CentigradeToKelvinCommand : IRequest<double>
    {
        public double Request { get; set; }

        public CentigradeToKelvinCommand(double request)
        {
            Request = request;
        }
    }
}
