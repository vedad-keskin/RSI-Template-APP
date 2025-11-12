using Festify.Data;
using Festify.Helper.Api;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static Festify.Endpoints.CountryEndpoints.CountryDeleteEndpoint;

namespace Festify.Endpoints.CountryEndpoints;

[Route("countries")]
public class CountryDeleteEndpoint(ApplicationDbContext db) : MyEndpointBaseAsync
    .WithRequest<CountryDeleteRequest>
    .WithoutResult
{
    [HttpDelete("{id}")]
    public override async Task HandleAsync([FromRoute] CountryDeleteRequest request, CancellationToken cancellationToken = default)
    {
        var country = await db.Countries.SingleOrDefaultAsync(x => x.ID == request.ID, cancellationToken);

        if (country == null)
        {
            throw new KeyNotFoundException("Country not found");
        }

        db.Countries.Remove(country);
        await db.SaveChangesAsync(cancellationToken);
    }

    public class CountryDeleteRequest
    {
        public int ID { get; set; }
    }
}

