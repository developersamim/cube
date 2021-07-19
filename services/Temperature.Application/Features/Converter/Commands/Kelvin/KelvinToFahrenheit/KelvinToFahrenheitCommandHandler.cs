using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Temperature.Application.Features.Converter.Commands.Centigrade.CentigradeToFahrenheit;
using Temperature.Application.Features.Converter.Commands.Kelvin.KelvinToCentigrade;

namespace Temperature.Application.Features.Converter.Commands.Kelvin.KelvinToFahrenheit
{
    public class KelvinToFahrenheitCommandHandler : IRequestHandler<KelvinToFahrenheitCommand, FahrenheitDto>
    {
        private readonly ILogger<KelvinToFahrenheitCommandHandler> logger;
        private readonly IMediator mediator;
        private readonly IMapper mapper;

        public KelvinToFahrenheitCommandHandler(ILogger<KelvinToFahrenheitCommandHandler> logger, IMediator mediator, IMapper mapper)
        {
            this.logger = logger;
            this.mediator = mediator;
            this.mapper = mapper;
        }

        public async Task<FahrenheitDto> Handle(KelvinToFahrenheitCommand request, CancellationToken cancellationToken)
        {

            var command = new KelvinToCentigradeCommand(request.Request);
            var centigrade = await mediator.Send(command);

            var cmd = new CentigradeToFahrenheitCommand(centigrade.Value);

            var fahrenheitDto = await mediator.Send(cmd);

            var dto = mapper.Map<FahrenheitDto>(fahrenheitDto);

            return dto;
        }
    }
}
