using Festify.Data.Models;
using Festify.Helper;
using Festify.Helper.BaseClasses;
using Festify.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq.Expressions;

namespace Festify.Data;

public partial class ApplicationDbContext(DbContextOptions options, IHttpContextAccessor httpContextAccessor) : DbContext(options)
{

    public DbSet<Category> Categories { get; set; }
    public DbSet<Gender> Genders { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<MyAppUser> MyAppUsers { get; set; }
    public DbSet<MyAuthenticationToken> MyAuthenticationTokens { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configure User entity
        modelBuilder.Entity<MyAppUser>()
            .HasIndex(u => u.Email)
            .IsUnique();

        modelBuilder.Entity<MyAppUser>()
            .HasIndex(u => u.Username)
            .IsUnique();

        // Configure Country entity
        modelBuilder.Entity<Country>()
            .HasIndex(c => c.Name)
            .IsUnique();

        // Configure City entity
        modelBuilder.Entity<City>()
            .HasIndex(c => new { c.Name, c.CountryId })
            .IsUnique();

        modelBuilder.Entity<City>()
            .HasOne(c => c.Country)
            .WithMany()
            .HasForeignKey(c => c.CountryId)
            .OnDelete(DeleteBehavior.Restrict);

        // Seed initial data
        modelBuilder.SeedData();
    }




}