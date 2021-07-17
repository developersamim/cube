using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Temperature.Application.Features.Converter.Commands.CentigradeToFahrenheit
{
    public class CentigradeToFahrenheitCommandHandler : IRequestHandler<CentigradeToFahrenheitCommand, double>
    {
        private readonly ILogger<CentigradeToFahrenheitCommandHandler> logger;

        public CentigradeToFahrenheitCommandHandler(ILogger<CentigradeToFahrenheitCommandHandler> logger)
        {
            this.logger = logger;
        }

        public Task<double> Handle(CentigradeToFahrenheitCommand request, CancellationToken cancellationToken)
        {
            double fahrenheit;

            fahrenheit = (request.Request * 9) / 5 + 32;

            return Task.FromResult(fahrenheit);
        }
    }
}
