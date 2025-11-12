namespace Festify.Endpoints.CityEndpoints;

using FluentValidation;
using static Festify.Endpoints.CityEndpoints.CityUpdateOrInsertEndpoint;

public class CategoryUpdateOrInsertValidator : AbstractValidator<CategoryUpdateOrInsertEndpoint.CategoryUpdateOrInsertRequest>
{
    public CategoryUpdateOrInsertValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Category name is required")
            .Matches(@"^[a-zA-ZÀ-ÿ\s]+$").WithMessage("Category name can only contain letters and spaces")
            .MaximumLength(100).WithMessage("Category name cannot exceed 100 characters");


    }
} 