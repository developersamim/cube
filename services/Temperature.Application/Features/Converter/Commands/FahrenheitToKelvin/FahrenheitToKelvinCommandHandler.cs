using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;
using Temperature.Application.Features.Converter.Commands.FahrenheitToCentigrade;

namespace Temperature.Application.Features.Converter.Commands.FahrenheitToKelvin
{
    public class FahrenheitToKelvinCommandHandler : IRequestHandler<FahrenheitToKelvinCommand, double>
    {
        private readonly ILogger<FahrenheitToKelvinCommandHandler> logger;
        private readonly IMediator mediator;

        public FahrenheitToKelvinCommandHandler(ILogger<FahrenheitToKelvinCommandHandler> logger, IMediator mediator)
        {
            this.logger = logger;
            this.mediator = mediator;
        }

        public async Task<double> Handle(FahrenheitToKelvinCommand request, CancellationToken cancellationToken)
        {
            double kelvin;

            var command = new FahrenheitToCentigradeCommand(request.Request);
            double centigrade = await mediator.Send(command);

            kelvin = centigrade + 273.15;

            return kelvin;
        }
    }
}
