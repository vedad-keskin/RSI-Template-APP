using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static Festify.Endpoints.GenderEndpoints.GenderUpdateOrInsertEndpoint;
using Festify.Data;
using Festify.Helper.Api;
using Festify.Data.Models;

namespace Festify.Endpoints.GenderEndpoints;

[Route("genders")]
public class GenderUpdateOrInsertEndpoint(ApplicationDbContext db) : MyEndpointBaseAsync
    .WithRequest<GenderUpdateOrInsertRequest>
    .WithResult<GenderUpdateOrInsertResponse>
{
    [HttpPost]
    public override async Task<GenderUpdateOrInsertResponse> HandleAsync([FromBody] GenderUpdateOrInsertRequest request, CancellationToken cancellationToken = default)
    {
        Gender gender;

        if (request.ID.HasValue)
        {
            // Update existing gender
            gender = await db.Set<Gender>().FirstOrDefaultAsync(g => g.ID == request.ID.Value, cancellationToken);
            if (gender == null)
            {
                throw new Exception($"Gender with ID {request.ID.Value} not found.");
            }

            gender.Name = request.Name;
            gender.IsActive = request.IsActive;
        }
        else
        {
            // Create new gender
            gender = new Gender
            {
                Name = request.Name,
                IsActive = request.IsActive
            };

            db.Set<Gender>().Add(gender);
        }

        await db.SaveChangesAsync(cancellationToken);

        return new GenderUpdateOrInsertResponse
        {
            ID = gender.ID,
            Name = gender.Name,
            CreatedAt = gender.CreatedAt,
            IsActive = gender.IsActive
        };
    }

    // DTO for request
    public class GenderUpdateOrInsertRequest
    {
        public int? ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
    }

    // DTO for response
    public class GenderUpdateOrInsertResponse
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
