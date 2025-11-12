using Festify.Data;
using Festify.Data.Models;
using Festify.Helper.Api;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static Festify.Endpoints.CityEndpoints.CategoryUpdateOrInsertEndpoint;
using static Festify.Endpoints.CityEndpoints.CityUpdateOrInsertEndpoint;

namespace Festify.Endpoints.CityEndpoints;

[Route("categories")]
public class CategoryUpdateOrInsertEndpoint(ApplicationDbContext db) : MyEndpointBaseAsync
    .WithRequest<CategoryUpdateOrInsertRequest>
    .WithoutResult
{
    [HttpPost]
    public override async Task HandleAsync([FromBody] CategoryUpdateOrInsertRequest request, CancellationToken cancellationToken = default)
    {
        bool isInsert = request.ID == null || request.ID == 0;
        Category? category;

        if (isInsert)
        {
            category = new Category();
            db.Categories.Add(category);
        }
        else
        {
            category = await db.Categories.SingleOrDefaultAsync(x => x.ID == request.ID, cancellationToken);

            if (category == null)
            {
                throw new KeyNotFoundException("Category not found");
            }
        }

        category.Name = request.Name;
        category.Description = request.Description;
        category.IsActive = request.IsActive;

        await db.SaveChangesAsync(cancellationToken);
    }

    public class CategoryUpdateOrInsertRequest
    {
        public int? ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public bool IsActive { get; set; } = true;
    }
} 