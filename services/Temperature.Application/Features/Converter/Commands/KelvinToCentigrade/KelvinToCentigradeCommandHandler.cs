using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Temperature.Application.Features.Converter.Commands.KelvinToCentigrade
{
    public class KelvinToCentigradeCommandHandler : IRequestHandler<KelvinToCentigradeCommand, double>
    {
        private readonly ILogger<KelvinToCentigradeCommandHandler> logger;

        public KelvinToCentigradeCommandHandler(ILogger<KelvinToCentigradeCommandHandler> logger)
        {
            this.logger = logger;
        }

        public Task<double> Handle(KelvinToCentigradeCommand request, CancellationToken cancellationToken)
        {
            double centigrade;

            centigrade = request.Request - 273.15;

            return Task.FromResult(centigrade);
        }
    }
}
