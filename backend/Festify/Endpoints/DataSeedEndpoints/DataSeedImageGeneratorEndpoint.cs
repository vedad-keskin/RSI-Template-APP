using Festify.Data;
using Festify.Data.Models;
using Festify.Helper.Api;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace Festify.Endpoints.DataSeedEndpoints
{
    [Route("data-seed")]
    public class DataSeedImageGeneratorEndpoint(ApplicationDbContext db)
        : MyEndpointBaseAsync
        .WithoutRequest
        .WithResult<string>
    {
        [HttpPost("generate-images")]
        public override async Task<string> HandleAsync(CancellationToken cancellationToken = default)
        {
            try
            {
                var countries = await db.Countries.ToListAsync(cancellationToken);

                if (!countries.Any())
                {
                    return "No countries found in the database. Please seed data first.";
                }

                int updatedCountriesCount = 0;
                int notFoundCountriesCount = 0;
                int skippedCountriesCount = 0;

                // Process countries
                foreach (var country in countries)
                {
                    // Skip if the country already has a flag
                    if (country.Flag != null && country.Flag.Length > 0)
                    {
                        skippedCountriesCount++;
                        continue;
                    }

                    string[] extensions = { ".jpg", ".png", ".jpeg" };
                    byte[]? imageBytes = null;

                    foreach (var ext in extensions)
                    {
                        string imageFilePath = Path.Combine("wwwroot", $"c{country.ID}{ext}");
                        if (System.IO.File.Exists(imageFilePath))
                        {
                            imageBytes = System.IO.File.ReadAllBytes(imageFilePath);
                            break;
                        }
                    }

                    if (imageBytes != null)
                    {
                        country.Flag = imageBytes;
                        updatedCountriesCount++;
                    }
                    else
                    {
                        notFoundCountriesCount++;
                    }
                }

                await db.SaveChangesAsync(cancellationToken);

                return $"Flag image generation completed successfully.\n" +
                       $"Countries: Updated {updatedCountriesCount}, {notFoundCountriesCount} flag images not found, Skipped {skippedCountriesCount} with existing flags.";
            }
            catch (Exception ex)
            {
                return $"Error generating flag images: {ex.Message}";
            }
        }
    }
}

