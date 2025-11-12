using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static Festify.Endpoints.GenderEndpoints.GenderGetAllEndpoint;
using Festify.Data;
using Festify.Helper.Api;
using Festify.Helper;
using Festify.Data.Models;

namespace Festify.Endpoints.GenderEndpoints;

[Route("genders")]
public class GenderGetAllEndpoint(ApplicationDbContext db) : MyEndpointBaseAsync
    .WithRequest<GenderGetAllRequest>
    .WithResult<MyPagedList<GenderGetAllResponse>>
{
    [HttpGet("filter")]
    public override async Task<MyPagedList<GenderGetAllResponse>> HandleAsync([FromQuery] GenderGetAllRequest request, CancellationToken cancellationToken = default)
    {
        // Base query for genders
        var query = db.Set<Gender>()
            .AsQueryable();

        // Apply filters for name search
        if (!string.IsNullOrWhiteSpace(request.Q))
        {
            query = query.Where(g => g.Name.Contains(request.Q));
        }

        // Project to DTO for result
        var projectedQuery = query.Select(g => new GenderGetAllResponse
        {
            ID = g.ID,
            Name = g.Name,
            CreatedAt = g.CreatedAt,
            IsActive = g.IsActive
        });

        // Create paginated result
        var result = await MyPagedList<GenderGetAllResponse>.CreateAsync(projectedQuery, request, cancellationToken);

        return result;
    }

    // DTO for request with pagination and filtering support
    public class GenderGetAllRequest : MyPagedRequest
    {
        public string? Q { get; set; } = string.Empty; // Text query for search
    }

    // DTO for response
    public class GenderGetAllResponse
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
