using Festify.Data;
using Festify.Helper.Api;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static Festify.Endpoints.CityEndpoints.CategoryGetByIdEndpoint;
using static Festify.Endpoints.CityEndpoints.CityGetByIdEndpoint;

namespace Festify.Endpoints.CityEndpoints;

[Route("categories")]
public class CategoryGetByIdEndpoint(ApplicationDbContext db) : MyEndpointBaseAsync
    .WithRequest<int>
    .WithActionResult<CategoryGetByIdResponse>
{
    [HttpGet("{id}")]
    public override async Task<ActionResult<CategoryGetByIdResponse>> HandleAsync(int id, CancellationToken cancellationToken = default)
    {
        var category = await db.Categories
            .Where(c => c.ID == id)
            .Select(c => new CategoryGetByIdResponse
            {
                ID = c.ID,
                Name = c.Name,
                Description = c.Description,
                IsActive = c.IsActive,
            })
            .SingleOrDefaultAsync(cancellationToken);

        if (category == null)
        {
            return NotFound("Category not found");
        }

        return Ok(category);
    }

    public class CategoryGetByIdResponse
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public bool IsActive { get; set; } = true;
    }
} 