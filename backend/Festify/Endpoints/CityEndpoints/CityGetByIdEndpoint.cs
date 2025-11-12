using Festify.Data;
using Festify.Helper.Api;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static Festify.Endpoints.CityEndpoints.CityGetByIdEndpoint;

namespace Festify.Endpoints.CityEndpoints;

[Route("cities")]
public class CityGetByIdEndpoint(ApplicationDbContext db) : MyEndpointBaseAsync
    .WithRequest<int>
    .WithActionResult<CityGetByIdResponse>
{
    [HttpGet("{id}")]
    public override async Task<ActionResult<CityGetByIdResponse>> HandleAsync(int id, CancellationToken cancellationToken = default)
    {
        var city = await db.Cities
            .Where(c => c.ID == id)
            .Select(c => new CityGetByIdResponse
            {
                ID = c.ID,
                Name = c.Name,
                CountryId = c.CountryId,
                CountryName = c.Country.Name
            })
            .SingleOrDefaultAsync(cancellationToken);

        if (city == null)
        {
            return NotFound("City not found");
        }

        return Ok(city);
    }

    public class CityGetByIdResponse
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public int CountryId { get; set; }
        public string CountryName { get; set; } = string.Empty;
    }
} 