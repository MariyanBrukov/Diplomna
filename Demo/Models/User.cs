using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        public DateTime DateCreated { get; set; } = DateTime.Now;

        // ✅ NEW: Admin flag
        public bool IsAdmin { get; set; } = false;

        public List<Build> Builds { get; set; } = new();
    }
}