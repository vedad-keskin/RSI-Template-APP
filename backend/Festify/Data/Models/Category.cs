using Festify.Helper.BaseClasses;
using System;

namespace Festify.Data.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public bool IsActive { get; set; } = true;
    }
} 