using Festify.Helper.BaseClasses;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Festify.Data.Models;

public class MyAuthenticationToken : BaseEntity
{
    public required string Value { get; set; } // Token string

    public string IpAddress { get; set; } = string.Empty;// IP address of the client

    public DateTime RecordedAt { get; set; } // Timestamp of token creation

    // Foreign key to link the token to a specific user
    [ForeignKey(nameof(MyAppUser))]
    public int MyAppUserId { get; set; }

    public MyAppUser? MyAppUser { get; set; } // Navigation property to the user
}
