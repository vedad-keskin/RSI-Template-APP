using Festify.Data;
using Festify.Helper.Api;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Festify.Endpoints.CategoryEndpoints;

[Route("categories")]
public class CategoryDeleteEndpoint(ApplicationDbContext db) : MyEndpointBaseAsync
    .WithRequest<int>
    .WithoutResult
{
    [HttpDelete("{id}")]
    public override async Task HandleAsync(int id, CancellationToken cancellationToken = default)
    {
        var category = await db.Categories.SingleOrDefaultAsync(x => x.ID == id, cancellationToken);

        if (category == null)
        {
            throw new KeyNotFoundException("Category not found");
        }

        category.IsActive = false;

        db.Categories.Update(category);

        await db.SaveChangesAsync(cancellationToken);
    }


} 