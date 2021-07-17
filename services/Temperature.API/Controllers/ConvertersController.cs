using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Temperature.API.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Temperature.API
{
    [Route("[controller]")]
    public class ConvertersController : ControllerBase
    {
        private readonly ILogger<ConvertersController> logger;
        private readonly IConverterService converterService;

        public ConvertersController(ILogger<ConvertersController> logger, IConverterService converterService)
        {
            this.logger = logger;
            this.converterService = converterService;
        }

        [HttpGet("[action]/{request}")]
        public async Task<ActionResult> CentigradeToFahrenheit(double request)
        {
            var result = await converterService.CentigradeToFahrenheit(request);

            return Ok(result);
        }

        [HttpGet("[action]/{request}")]
        public async Task<ActionResult> CentigradeToKelvin(double request)
        {
            var result = await converterService.CentigradeToKelvin(request);

            return Ok(result);
        }

        [HttpGet("[action]/{request}")]
        public async Task<ActionResult> FahrenheitToCentigrade(double request)
        {
            var result = await converterService.FahrenheitToCentigrade(request);

            return Ok(result);
        }

        [HttpGet("[action]/{request}")]
        public async Task<ActionResult> FahrenheitToKelvin(double request)
        {
            var result = await converterService.FahrenheitToKelvin(request);

            return Ok(result);
        }

        [HttpGet("[action]/{request}")]
        public async Task<ActionResult> KelvinToCentigrade(double request)
        {
            var result = await converterService.KelvinToCentigrade(request);

            return Ok(result);
        }

        [HttpGet("[action]/{request}")]
        public async Task<ActionResult> KelvinToFahrenheit(double request)
        {
            var result = await converterService.KelvinToFahrenheit(request);

            return Ok(result);
        }
    }
}
