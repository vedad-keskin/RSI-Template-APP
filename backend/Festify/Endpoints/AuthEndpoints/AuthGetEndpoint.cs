using Azure;
using Festify.Helper.Api;
using Festify.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;
using static Festify.Endpoints.AuthEndpoints.AuthGetEndpoint;

namespace Festify.Endpoints.AuthEndpoints;

[Route("auth")]
public class AuthGetEndpoint(IMyAuthService authService) : MyEndpointBaseAsync
    .WithoutRequest
    .WithActionResult<AuthGetResponse>
{
    [HttpGet]
    public override async Task<ActionResult<AuthGetResponse>> HandleAsync(CancellationToken cancellationToken = default)
    {
        // Retrieve user info based on the token
        var authInfo = authService.GetAuthInfoFromRequest();

        if (!authInfo.IsLoggedIn)
        {
            return Unauthorized("Invalid or expired token");
        }

        // Return user information if the token is valid
        return Ok(new AuthGetResponse
        {
            MyAuthInfo = authInfo
        });
    }

    public class AuthGetResponse
    {
        public required MyAuthInfo MyAuthInfo { get; set; }
    }
}
