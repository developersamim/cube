using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Temperature.Application.Features.Converter.Commands.Fahrenheit.FahrenheitToCentigrade;

namespace Temperature.Application.Features.Converter.Commands.Fahrenheit.FahrenheitToKelvin
{
    public class FahrenheitToKelvinCommandHandler : IRequestHandler<FahrenheitToKelvinCommand, KelvinDto>
    {
        private readonly ILogger<FahrenheitToKelvinCommandHandler> logger;
        private readonly IMediator mediator;
        private readonly IMapper mapper;

        public FahrenheitToKelvinCommandHandler(ILogger<FahrenheitToKelvinCommandHandler> logger, IMediator mediator, IMapper mapper)
        {
            this.logger = logger;
            this.mediator = mediator;
            this.mapper = mapper;
        }

        public async Task<KelvinDto> Handle(FahrenheitToKelvinCommand request, CancellationToken cancellationToken)
        {
            var kelvin = new Core.Entities.Kelvin();

            var command = new FahrenheitToCentigradeCommand(request.Request);
            var centigrade = await mediator.Send(command);

            
            kelvin.Value = centigrade.Value + 273.15;

            var kelvinDto = mapper.Map<KelvinDto>(kelvin);

            return kelvinDto;
        }
    }
}
