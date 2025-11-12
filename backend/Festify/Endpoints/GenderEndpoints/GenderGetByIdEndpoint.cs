using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static Festify.Endpoints.GenderEndpoints.GenderGetByIdEndpoint;
using Festify.Data;
using Festify.Helper.Api;
using Festify.Data.Models;

namespace Festify.Endpoints.GenderEndpoints;

[Route("genders")]
public class GenderGetByIdEndpoint(ApplicationDbContext db) : MyEndpointBaseAsync
    .WithRequest<GenderGetByIdRequest>
    .WithResult<GenderGetByIdResponse>
{
    [HttpGet("{id}")]
    public override async Task<GenderGetByIdResponse> HandleAsync([FromRoute] GenderGetByIdRequest request, CancellationToken cancellationToken = default)
    {
        var gender = await db.Set<Gender>()
            .FirstOrDefaultAsync(g => g.ID == request.ID, cancellationToken);

        if (gender == null)
        {
            throw new Exception($"Gender with ID {request.ID} not found.");
        }

        return new GenderGetByIdResponse
        {
            ID = gender.ID,
            Name = gender.Name,
            CreatedAt = gender.CreatedAt,
            IsActive = gender.IsActive
        };
    }

    // DTO for request
    public class GenderGetByIdRequest
    {
        public int ID { get; set; }
    }

    // DTO for response
    public class GenderGetByIdResponse
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
