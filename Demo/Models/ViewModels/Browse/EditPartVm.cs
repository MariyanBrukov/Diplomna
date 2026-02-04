using System.ComponentModel.DataAnnotations;
using Demo.Models;
using Microsoft.AspNetCore.Http;

namespace Demo.Models.ViewModels.Browse
{
    public class EditPartVm
    {
        public PartType PartType { get; set; }
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = "";

        [Required]
        public string Brand { get; set; } = "";

        public decimal Price { get; set; }

        public string? Description { get; set; }

        public string? ExistingImageUrl { get; set; }

        public IFormFile? ImageFile { get; set; }

        // Optional fields
        public string? Socket { get; set; }
        public int? Cores { get; set; }
        public float? ClockSpeedGHz { get; set; }

        public int? MemoryGB { get; set; }
        public string? Chipset { get; set; }

        public int? CapacityGB { get; set; }
        public string? RamType { get; set; }
        public int? SpeedMHz { get; set; }

        public string? FormFactor { get; set; }
        public int? Wattage { get; set; }
        public string? Efficiency { get; set; }
        public string? StorageType { get; set; }
        public string? Color { get; set; }
    }
}
