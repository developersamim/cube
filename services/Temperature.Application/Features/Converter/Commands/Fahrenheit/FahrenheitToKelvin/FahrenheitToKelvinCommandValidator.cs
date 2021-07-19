using System;
using FluentValidation;

namespace Temperature.Application.Features.Converter.Commands.Fahrenheit.FahrenheitToKelvin
{
    public class FahrenheitToKelvinCommandValidator : AbstractValidator<FahrenheitToKelvinCommand>
    {
        public FahrenheitToKelvinCommandValidator()
        {
            RuleFor(p => p.Request)
                .GreaterThanOrEqualTo(-459.67).WithMessage("{Request} must not be less than -459.67");
        }
    }
}
