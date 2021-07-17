using System;
using FluentValidation;

namespace Temperature.Application.Features.Converter.Commands.CentigradeToKelvin
{
    public class CentigradeToKelvinCommandValidator : AbstractValidator<CentigradeToKelvinCommand>
    {
        public CentigradeToKelvinCommandValidator()
        {
            RuleFor(p => p.Request)
                .GreaterThanOrEqualTo(-273.15).WithMessage("{Request} must not be less than -273.15");
        }
    }
}
