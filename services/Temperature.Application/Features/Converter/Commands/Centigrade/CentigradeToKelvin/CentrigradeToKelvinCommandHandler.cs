using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Temperature.Application.Features.Converter.Commands.Centigrade.CentigradeToKelvin
{
    public class CentrigradeToKelvinCommandHandler : IRequestHandler<CentigradeToKelvinCommand, KelvinDto>
    {
        private readonly ILogger<CentrigradeToKelvinCommandHandler> logger;
        private readonly IMapper mapper;
        private const double CelsiusKelvin = 273.15;

        public CentrigradeToKelvinCommandHandler(ILogger<CentrigradeToKelvinCommandHandler> logger, IMapper mapper)
        {
            this.logger = logger;
            this.mapper = mapper;
        }

        public Task<KelvinDto> Handle(CentigradeToKelvinCommand request, CancellationToken cancellationToken)
        {
            var kelvin = new Core.Entities.Kelvin();

            kelvin.Value = request.Request + CelsiusKelvin;

            var kelvinDto = mapper.Map<KelvinDto>(kelvin);

            return Task.FromResult(kelvinDto);
        }
    }
}
