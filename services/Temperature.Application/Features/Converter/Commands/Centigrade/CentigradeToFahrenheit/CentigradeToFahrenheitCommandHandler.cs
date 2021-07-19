using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Temperature.Application.Features.Converter.Commands.Centigrade.CentigradeToFahrenheit
{
    public class CentigradeToFahrenheitCommandHandler : IRequestHandler<CentigradeToFahrenheitCommand, FahrenheitDto>
    {
        private readonly ILogger<CentigradeToFahrenheitCommandHandler> logger;
        private readonly IMapper mapper;

        public CentigradeToFahrenheitCommandHandler(ILogger<CentigradeToFahrenheitCommandHandler> logger, IMapper mapper)
        {
            this.logger = logger;
            this.mapper = mapper;
        }

        public Task<FahrenheitDto> Handle(CentigradeToFahrenheitCommand request, CancellationToken cancellationToken)
        {
            var fahrenheit = new Core.Entities.Fahrenheit();

            fahrenheit.Value = (request.Request * 9) / 5 + 32;

            var fahrenheitDto = mapper.Map<FahrenheitDto>(fahrenheit);

            return Task.FromResult(fahrenheitDto);
        }
    }
}
