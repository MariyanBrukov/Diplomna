using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public abstract class PartBase
    {
        public int Id { get; set; }

        [Required, StringLength(120)]
        public string Name { get; set; } = string.Empty;

        [StringLength(4000)]
        public string? Description { get; set; }

        [Range(0, 100000)]
        public decimal Price { get; set; }

        // Simple image storage: URL or relative path like "/images/parts/xyz.jpg"
        [StringLength(400)]
        public string? ImageUrl { get; set; }

        // Brand as a simple string for now (easiest to retrofit)
        // Later we can normalize to a Brand table if you want.
        [Required, StringLength(80)]
        public string Brand { get; set; } = string.Empty;

        // Allows you to hide items without deleting
        public bool IsActive { get; set; } = true;

        public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;
    }
}
