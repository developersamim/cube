using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;
using Temperature.Application.Features.Converter.Commands.CentigradeToFahrenheit;
using Temperature.Application.Features.Converter.Commands.KelvinToCentigrade;

namespace Temperature.Application.Features.Converter.Commands.KelvinToFahrenheit
{
    public class KelvinToFahrenheitCommandHandler : IRequestHandler<KelvinToFahrenheitCommand, double>
    {
        private readonly ILogger<KelvinToFahrenheitCommandHandler> logger;
        private readonly IMediator mediator;

        public KelvinToFahrenheitCommandHandler(ILogger<KelvinToFahrenheitCommandHandler> logger, IMediator mediator)
        {
            this.logger = logger;
            this.mediator = mediator;
        }

        public async Task<double> Handle(KelvinToFahrenheitCommand request, CancellationToken cancellationToken)
        {
            var command = new KelvinToCentigradeCommand(request.Request);
            double centigrade = await mediator.Send(command);

            var cmd = new CentigradeToFahrenheitCommand(centigrade);
            double fahrenheit = await mediator.Send(cmd);

            return fahrenheit;
        }
    }
}
