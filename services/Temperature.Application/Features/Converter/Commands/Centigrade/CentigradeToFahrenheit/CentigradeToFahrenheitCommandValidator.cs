using System;
using FluentValidation;

namespace Temperature.Application.Features.Converter.Commands.Centigrade.CentigradeToFahrenheit
{
    public class CentigradeToFahrenheitCommandValidator : AbstractValidator<CentigradeToFahrenheitCommand>
    {
        public CentigradeToFahrenheitCommandValidator()
        {
            RuleFor(p => p.Request)
                .GreaterThanOrEqualTo(-273.15).WithMessage("{Request} must not be less than -273.15");
        }
    }
}
