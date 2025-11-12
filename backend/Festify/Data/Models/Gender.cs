using Festify.Helper.BaseClasses;
using System;

namespace Festify.Data.Models
{
    public class Gender : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;

    }
} 