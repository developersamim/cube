using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Temperature.Application.Features.Converter.Commands.CentigradeToKelvin
{
    public class CentrigradeToKelvinCommandHandler : IRequestHandler<CentigradeToKelvinCommand, double>
    {
        private readonly ILogger<CentrigradeToKelvinCommandHandler> logger;
        private const double CelsiusKelvin = 273.15;

        public CentrigradeToKelvinCommandHandler(ILogger<CentrigradeToKelvinCommandHandler> logger)
        {
            this.logger = logger;
        }

        public Task<double> Handle(CentigradeToKelvinCommand request, CancellationToken cancellationToken)
        {
            double kelvin;

            kelvin = request.Request + CelsiusKelvin;

            return Task.FromResult(kelvin);
        }
    }
}
