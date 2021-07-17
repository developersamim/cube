using System;
using FluentValidation;

namespace Temperature.Application.Features.Converter.Commands.KelvinToFahrenheit
{
    public class KelvinToFahrenheitCommandValidator : AbstractValidator<KelvinToFahrenheitCommand>
    {
        public KelvinToFahrenheitCommandValidator()
        {
            RuleFor(p => p.Request)
                .GreaterThanOrEqualTo(0).WithMessage("{Request} must not be less than 0");
        }
    }
}
