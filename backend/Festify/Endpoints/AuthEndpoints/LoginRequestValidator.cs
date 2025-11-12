namespace Festify.Endpoints.AuthEndpoints;

using FluentValidation;
using static Festify.Endpoints.AuthEndpoints.AuthLoginEndpoint;

public class LoginRequestValidator : AbstractValidator<LoginRequest>
{
    public LoginRequestValidator()
    {
        // Validacija Email polja
        RuleFor(x => x.Username)
            .NotEmpty().WithMessage("Username is required.");

        // Validacija Password polja
        RuleFor(x => x.Password)
            .NotEmpty().WithMessage("Password is required.");
    }
}
