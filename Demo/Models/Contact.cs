using System;
using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class Contact
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [StringLength(100)]
        public string Subject { get; set; } = string.Empty;

        [Required]
        [StringLength(500)]
        public string Message { get; set; } = string.Empty;

        // ✅ NEW: Admin reply
        public string? AdminReply { get; set; }

        // ✅ NEW: When admin replied
        public DateTime? ReplyDate { get; set; }

        // ✅ NEW: Status
        public bool IsAnswered { get; set; } = false;

        // ✅ Optional: When created
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}