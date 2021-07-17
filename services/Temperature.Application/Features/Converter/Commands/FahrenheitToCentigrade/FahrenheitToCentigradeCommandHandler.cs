using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Temperature.Application.Features.Converter.Commands.FahrenheitToCentigrade
{
    public class FahrenheitToCentigradeCommandHandler : IRequestHandler<FahrenheitToCentigradeCommand, double>
    {
        private readonly ILogger<FahrenheitToCentigradeCommandHandler> logger;

        public FahrenheitToCentigradeCommandHandler(ILogger<FahrenheitToCentigradeCommandHandler> logger)
        {
            this.logger = logger;
        }

        public Task<double> Handle(FahrenheitToCentigradeCommand request, CancellationToken cancellationToken)
        {
            double centigrade;

            centigrade = (request.Request - 32) * 5 / 9;

            return Task.FromResult(centigrade);
        }
    }
}
