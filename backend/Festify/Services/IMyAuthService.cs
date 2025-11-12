using Festify.Data.Models;

namespace Festify.Services
{
    public interface IMyAuthService
    {
        Task<MyAuthenticationToken> GenerateSaveAuthToken(MyAppUser user, CancellationToken cancellationToken = default);
        Task<bool> RevokeAuthToken(string tokenValue, CancellationToken cancellationToken = default);
        MyAuthInfo GetAuthInfoFromTokenString(string? authToken);
        MyAuthInfo GetAuthInfoFromRequest();
        MyAuthInfo GetAuthInfoFromTokenModel(MyAuthenticationToken? myAuthToken);
    }

}
