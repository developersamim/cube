using System;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;
using Temperature.API.Utilities;
using Temperature.Application.Features.Converter.Commands.Centigrade.CentigradeToFahrenheit;
using Temperature.Application.Features.Converter.Commands.Centigrade.CentigradeToKelvin;
using Temperature.Application.Features.Converter.Commands.Fahrenheit.FahrenheitToCentigrade;
using Temperature.Application.Features.Converter.Commands.Fahrenheit.FahrenheitToKelvin;
using Temperature.Application.Features.Converter.Commands.Kelvin.KelvinToCentigrade;
using Temperature.Application.Features.Converter.Commands.Kelvin.KelvinToFahrenheit;

namespace Temperature.API.Services
{
    public class ConverterService : IConverterService
    {
        private readonly ILogger<ConverterService> logger;
        private readonly IMediator mediator;

        public ConverterService(ILogger<ConverterService> logger, IMediator mediator)
        {
            this.logger = logger;
            this.mediator = mediator;
        }

        public async Task<double> CentigradeToFahrenheit(double request)
        {
            var command = new CentigradeToFahrenheitCommand(request);

            var result = await mediator.Send(command);

            return Helper.ToTwoPointDecimal(result.Value);
        }

        public async Task<double> CentigradeToKelvin(double request)
        {
            var command = new CentigradeToKelvinCommand(request);

            var result = await mediator.Send(command);

            return Helper.ToTwoPointDecimal(result.Value);
        }

        public async Task<double> FahrenheitToCentigrade(double request)
        {
            var command = new FahrenheitToCentigradeCommand(request);

            var result = await mediator.Send(command);

            return Helper.ToTwoPointDecimal(result.Value);
        }

        public async Task<double> FahrenheitToKelvin(double request)
        {
            var command = new FahrenheitToKelvinCommand(request);

            var result = await mediator.Send(command);

            return Helper.ToTwoPointDecimal(result.Value);
        }

        public async Task<double> KelvinToCentigrade(double request)
        {
            var command = new KelvinToCentigradeCommand(request);

            var result = await mediator.Send(command);

            return Helper.ToTwoPointDecimal(result.Value);
        }

        public async Task<double> KelvinToFahrenheit(double request)
        {
            var command = new KelvinToFahrenheitCommand(request);

            var result = await mediator.Send(command);

            return Helper.ToTwoPointDecimal(result.Value);
        }
    }
}
