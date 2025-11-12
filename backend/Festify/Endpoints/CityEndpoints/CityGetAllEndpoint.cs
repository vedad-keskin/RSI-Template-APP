using Festify.Data;
using Festify.Helper;
using Festify.Helper.Api;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static Festify.Endpoints.CityEndpoints.CityGetAllEndpoint;

namespace Festify.Endpoints.CityEndpoints;

[Route("cities")]
public class CityGetAllEndpoint(ApplicationDbContext db) : MyEndpointBaseAsync
    .WithRequest<CityGetAllRequest>
    .WithResult<MyPagedList<CityGetAllResponse>>
{
    [HttpGet("filter")]
    public override async Task<MyPagedList<CityGetAllResponse>> HandleAsync([FromQuery] CityGetAllRequest request, CancellationToken cancellationToken = default)
    {
        var query = db.Cities
            .AsQueryable();

        // Filter by search query
        if (!string.IsNullOrWhiteSpace(request.Q))
        {
            query = query.Where(c => c.Name.Contains(request.Q));
        }

        // Project to result type
        var projectedQuery = query.Select(c => new CityGetAllResponse
        {
            ID = c.ID,
            Name = c.Name,
            CountryId = c.CountryId,
            CountryName = c.Country.Name
        });

        // Create paginated response with filter
        var result = await MyPagedList<CityGetAllResponse>.CreateAsync(projectedQuery, request, cancellationToken);

        return result;
    }

    public class CityGetAllRequest : MyPagedRequest
    {
        public string? Q { get; set; } = string.Empty;
    }

    public class CityGetAllResponse
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public int CountryId { get; set; }
        public string CountryName { get; set; } = string.Empty;
    }
} 