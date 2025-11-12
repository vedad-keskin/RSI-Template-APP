using Festify.Data;
using Festify.Helper;
using Festify.Helper.Api;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static Festify.Endpoints.CityEndpoints.CategoryGetAllEndpoint;
using static Festify.Endpoints.CityEndpoints.CityGetAllEndpoint;

namespace Festify.Endpoints.CityEndpoints;

[Route("categories")]
public class CategoryGetAllEndpoint(ApplicationDbContext db) : MyEndpointBaseAsync
    .WithRequest<CategoryGetAllRequest>
    .WithResult<MyPagedList<CategoryGetAllResponse>>
{
    [HttpGet("filter")]
    public override async Task<MyPagedList<CategoryGetAllResponse>> HandleAsync([FromQuery] CategoryGetAllRequest request, CancellationToken cancellationToken = default)
    {
        var query = db.Categories
            .AsQueryable();

        // Filter by search query
        if (!string.IsNullOrWhiteSpace(request.Q))
        {
            query = query.Where(c => c.Name.Contains(request.Q) || c.Description.Contains(request.Q));
        }

        // Project to result type
        var projectedQuery = query.Select(c => new CategoryGetAllResponse
        {
            ID = c.ID,
            Name = c.Name,
            Description = c.Description,
            IsActive = c.IsActive,
        });

        // Create paginated response with filter
        var result = await MyPagedList<CategoryGetAllResponse>.CreateAsync(projectedQuery, request, cancellationToken);

        return result;
    }

    public class CategoryGetAllRequest : MyPagedRequest
    {
        public string? Q { get; set; } = string.Empty;
    }

    public class CategoryGetAllResponse
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public bool IsActive { get; set; } = true;
    }
} 