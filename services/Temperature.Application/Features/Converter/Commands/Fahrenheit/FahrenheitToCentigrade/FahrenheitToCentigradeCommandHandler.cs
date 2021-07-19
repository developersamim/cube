using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Temperature.Application.Features.Converter.Commands.Fahrenheit.FahrenheitToCentigrade
{
    public class FahrenheitToCentigradeCommandHandler : IRequestHandler<FahrenheitToCentigradeCommand, CentigradeDto>
    {
        private readonly ILogger<FahrenheitToCentigradeCommandHandler> logger;
        private readonly IMapper mapper;

        public FahrenheitToCentigradeCommandHandler(ILogger<FahrenheitToCentigradeCommandHandler> logger, IMapper mapper)
        {
            this.logger = logger;
            this.mapper = mapper;
        }

        public Task<CentigradeDto> Handle(FahrenheitToCentigradeCommand request, CancellationToken cancellationToken)
        {
            var centigrade = new Core.Entities.Centigrade();

            centigrade.Value = (request.Request - 32) * 5 / 9;

            var centigradeDto = mapper.Map<CentigradeDto>(centigrade);

            return Task.FromResult(centigradeDto);
        }
    }
}
