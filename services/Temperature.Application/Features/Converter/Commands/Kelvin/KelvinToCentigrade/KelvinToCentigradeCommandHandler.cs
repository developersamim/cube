using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Temperature.Application.Features.Converter.Commands.Kelvin.KelvinToCentigrade
{
    public class KelvinToCentigradeCommandHandler : IRequestHandler<KelvinToCentigradeCommand, CentigradeDto>
    {
        private readonly ILogger<KelvinToCentigradeCommandHandler> logger;
        private readonly IMapper mapper;

        public KelvinToCentigradeCommandHandler(ILogger<KelvinToCentigradeCommandHandler> logger, IMapper mapper)
        {
            this.logger = logger;
            this.mapper = mapper;
        }

        public Task<CentigradeDto> Handle(KelvinToCentigradeCommand request, CancellationToken cancellationToken)
        {
            var centigrade = new Core.Entities.Centigrade();

            centigrade.Value = request.Request - 273.15;

            var centigradeDto = mapper.Map<CentigradeDto>(centigrade);

            return Task.FromResult(centigradeDto);
        }
    }
}
