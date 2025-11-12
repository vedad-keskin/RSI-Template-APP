using Festify.Data;
using Festify.Helper;
using Festify.Helper.Api;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static Festify.Endpoints.UserEndpoints.UserGetAllEndpoint;

namespace Festify.Endpoints.UserEndpoints;

[Route("users")]
public class UserGetAllEndpoint(ApplicationDbContext db) : MyEndpointBaseAsync
    .WithRequest<UserGetAllRequest>
    .WithResult<MyPagedList<UserGetAllResponse>>
{
    [HttpGet("filter")]
    public override async Task<MyPagedList<UserGetAllResponse>> HandleAsync([FromQuery] UserGetAllRequest request, CancellationToken cancellationToken = default)
    {
        var query = db.MyAppUsers
            .Include(u => u.Gender)
            .Include(u => u.City)
            .AsQueryable();

        // Filter by search query
        if (!string.IsNullOrWhiteSpace(request.Q))
        {
            query = query.Where(u =>
                u.Username.Contains(request.Q) ||
                u.FirstName.Contains(request.Q) ||
                u.LastName.Contains(request.Q) ||
                u.Email.Contains(request.Q) ||
                u.PhoneNumber != null && u.PhoneNumber.Contains(request.Q)
            );
        }

        // Filter by role
        if (request.IsAdmin.HasValue)
        {
            query = query.Where(u => u.IsAdmin == request.IsAdmin.Value);
        }

        if (request.IsUser.HasValue)
        {
            query = query.Where(u => u.IsUser == request.IsUser.Value);
        }

        // Filter by active status
        if (request.IsActive.HasValue)
        {
            query = query.Where(u => u.IsActive == request.IsActive.Value);
        }

        // Project to result type
        var projectedQuery = query.Select(u => new UserGetAllResponse
        {
            ID = u.ID,
            Username = u.Username,
            FirstName = u.FirstName,
            LastName = u.LastName,
            FullName = $"{u.FirstName} {u.LastName}",
            Email = u.Email,
            PhoneNumber = u.PhoneNumber,
            IsActive = u.IsActive,
            IsAdmin = u.IsAdmin,
            IsUser = u.IsUser,
            GenderName = u.Gender.Name,
            CityName = u.City.Name,
            CreatedAt = u.CreatedAt,
            FailedLoginAttempts = u.FailedLoginAttempts,
            IsLocked = u.LockoutUntil.HasValue && u.LockoutUntil.Value > DateTime.UtcNow
        });

        // Create paginated response with filter
        var result = await MyPagedList<UserGetAllResponse>.CreateAsync(projectedQuery, request, cancellationToken);

        return result;
    }

    public class UserGetAllRequest : MyPagedRequest
    {
        public string? Q { get; set; } = string.Empty;
        public bool? IsAdmin { get; set; }
        public bool? IsUser { get; set; }
        public bool? IsActive { get; set; }
    }

    public class UserGetAllResponse
    {
        public int ID { get; set; }
        public string Username { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? PhoneNumber { get; set; }
        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsUser { get; set; }
        public string GenderName { get; set; } = string.Empty;
        public string CityName { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public int FailedLoginAttempts { get; set; }
        public bool IsLocked { get; set; }
    }
}
