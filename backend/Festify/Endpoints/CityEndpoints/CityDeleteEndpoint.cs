using Festify.Data;
using Festify.Helper.Api;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static Festify.Endpoints.CityEndpoints.CityDeleteEndpoint;

namespace Festify.Endpoints.CityEndpoints;

[Route("cities")]
public class CityDeleteEndpoint(ApplicationDbContext db) : MyEndpointBaseAsync
    .WithRequest<int>
    .WithoutResult
{
    [HttpDelete("{id}")]
    public override async Task HandleAsync(int id, CancellationToken cancellationToken = default)
    {
        var city = await db.Cities.SingleOrDefaultAsync(x => x.ID == id, cancellationToken);

        if (city == null)
        {
            throw new KeyNotFoundException("City not found");
        }

        city.IsActive = false;

        db.Cities.Update(city);

        await db.SaveChangesAsync(cancellationToken);
    }


} 