using Festify.Helper;
using Festify.Helper.BaseClasses;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Festify.Data.Models;

public class MyAppUser : BaseEntity
{

    public string Username { get; set; }
    [JsonIgnore]
    public string PasswordSalt { get; set; }

    [JsonIgnore]
    public string PasswordHash { get; set; }

    // Additional properties
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }

    // public byte[]? Picture { get; set; }

    public bool IsActive { get; set; } = true;

    [Phone]
    [MaxLength(20)]
    public string? PhoneNumber { get; set; }

    // Foreign keys for Gender and City
    public int GenderId { get; set; }
    public int CityId { get; set; }

    // Navigation properties
    public Gender Gender { get; set; } = null!;
    public City City { get; set; } = null!;


    //----------------
    public bool IsAdmin { get; set; }
    public bool IsUser { get; set; }

 
    public int FailedLoginAttempts { get; set; } = 0;

    // Timestamp for when the account might be locked (optional)
    public DateTime? LockoutUntil { get; set; }

    // Helper method for password hashing
    public void SetPassword(string password)
    {
        var hasher = new PasswordHasher<MyAppUser>();
        PasswordHash = hasher.HashPassword(this, password);
    }

    // Helper method for password verification
    public bool VerifyPassword(string password)
    {
        // Regenerate the hash using the stored salt and the provided password
        string computedHash = PasswordGenerator.GenerateHash(PasswordSalt, password);

        // Compare the computed hash with the stored hash
        bool isPasswordCorrect = computedHash == PasswordHash;

        if (isPasswordCorrect)
        {
            // Reset failed login attempts on successful login
            FailedLoginAttempts = 0;
            LockoutUntil = null; // Reset lockout if it was set
            return true;
        }
        else
        {
            // Increment failed login attempts on unsuccessful login
            FailedLoginAttempts++;
            return false;
        }
    }

    // Check if account is locked
    public bool IsLocked()
    {
        return LockoutUntil.HasValue && LockoutUntil.Value > DateTime.UtcNow;
    }

    // Lock account for a specific duration
    public void LockAccount(int minutes)
    {
        LockoutUntil = DateTime.UtcNow.AddMinutes(minutes);
    }

}
