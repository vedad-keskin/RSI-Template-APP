using System;
using System.Text.Json.Serialization;
using Festify.Data;
using Festify.Data.Models;
using Festify.Helper;
using Microsoft.EntityFrameworkCore;

namespace Festify.Services
{
    public class MyAuthServiceHelper
        //(ApplicationDbContext applicationDbContext, IHttpContextAccessor httpContextAccessor, MyTokenGenerator myTokenGenerator)
    {

        // Generisanje novog tokena za korisnika
        public static async Task<MyAuthenticationToken> GenerateSaveAuthToken(string? IpAddress, ApplicationDbContext applicationDbContext, MyAppUser user, CancellationToken cancellationToken = default)
        {
            string randomToken = MyTokenGenerator.Generate(10);

            var authToken = new MyAuthenticationToken
            {
                IpAddress = IpAddress ?? string.Empty,
                Value = randomToken,
                MyAppUser = user,
                RecordedAt = DateTime.Now,
            };

            applicationDbContext.Add(authToken);
            await applicationDbContext.SaveChangesAsync(cancellationToken);

            return authToken;
        }

        // Uklanjanje tokena iz baze podataka
        public static async Task<bool> RevokeAuthToken(ApplicationDbContext applicationDbContext, string tokenValue, CancellationToken cancellationToken = default)
        {
            var authToken = await applicationDbContext.MyAuthenticationTokens
                .FirstOrDefaultAsync(t => t.Value == tokenValue, cancellationToken);

            if (authToken == null)
                return false;

            applicationDbContext.Remove(authToken);
            await applicationDbContext.SaveChangesAsync(cancellationToken);

            return true;
        }

        // Dohvatanje informacija o autentifikaciji korisnika
        public static MyAuthInfo GetAuthInfoFromTokenString(ApplicationDbContext applicationDbContext, string? authToken)
        {
            if (string.IsNullOrEmpty(authToken))
            {
                return GetAuthInfoFromTokenModel(null);
            }

            MyAuthenticationToken? myAuthToken = applicationDbContext.MyAuthenticationTokens
                .IgnoreQueryFilters()
                .SingleOrDefault(x => x.Value == authToken);

            return GetAuthInfoFromTokenModel(myAuthToken);
        }


        // Dohvatanje informacija o autentifikaciji korisnika
        public static MyAuthInfo GetAuthInfoFromRequest(ApplicationDbContext applicationDbContext, IHttpContextAccessor httpContextAccessor)
        {
            string? authToken = httpContextAccessor.HttpContext?.Request.Headers["my-auth-token"];
            return GetAuthInfoFromTokenString(applicationDbContext, authToken);
        }

        public static MyAuthInfo GetAuthInfoFromTokenModel(MyAuthenticationToken? myAuthToken)
        {
            if (myAuthToken == null)
            {
                return new MyAuthInfo
                {
                    IsAdmin = false,
                    IsUser = false,
                    IsLoggedIn = false,
                };
            }

            return new MyAuthInfo
            {
                UserId = myAuthToken.MyAppUserId,
                Email = myAuthToken.MyAppUser!.Email,
                FirstName = myAuthToken.MyAppUser.FirstName,
                LastName = myAuthToken.MyAppUser.LastName,
                IsAdmin = myAuthToken.MyAppUser.IsAdmin,
                IsUser = myAuthToken.MyAppUser.IsUser,
                IsLoggedIn = true,
            };
        }
    }

    // DTO to hold authentication information
    public class MyAuthInfo
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsUser { get; set; }
        public bool IsLoggedIn { get; set; }
        public string SlikaPath {  get; set; }
    }
}
