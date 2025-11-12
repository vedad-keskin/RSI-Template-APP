namespace Festify.Endpoints.CountryEndpoints;

using FluentValidation;
using static Festify.Endpoints.CountryEndpoints.CountryUpdateOrInsertEndpoint;

public class CountryUpdateOrInsertValidator : AbstractValidator<CountryUpdateOrInsertRequest>
{
    public CountryUpdateOrInsertValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Country name is required")
            .Matches(@"^[a-zA-ZÀ-ÿ\s]+$").WithMessage("Country name can only contain letters and spaces")
            .MaximumLength(100).WithMessage("Country name cannot exceed 100 characters");
    }
}

