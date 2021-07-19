using System;
using FluentValidation;

namespace Temperature.Application.Features.Converter.Commands.Fahrenheit.FahrenheitToCentigrade
{
    public class FahrenheitToCentigradeCommandValidator : AbstractValidator<FahrenheitToCentigradeCommand>
    {
        public FahrenheitToCentigradeCommandValidator()
        {
            RuleFor(p => p.Request)
                .GreaterThanOrEqualTo(-459.67).WithMessage("{Request} must not be less than -459.67");
        }
    }
}
