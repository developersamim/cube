using System;
using FluentValidation;

namespace Temperature.Application.Features.Converter.Commands.KelvinToCentigrade
{
    public class KelvinToCentigradeCommandValidator : AbstractValidator<KelvinToCentigradeCommand>
    {
        public KelvinToCentigradeCommandValidator()
        {
            RuleFor(p => p.Request)
                .GreaterThanOrEqualTo(0).WithMessage("{Request} must not be less than 0");
        }
    }
}
