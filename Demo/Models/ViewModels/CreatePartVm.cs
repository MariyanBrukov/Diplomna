using System.ComponentModel.DataAnnotations;
using Demo.Models;

namespace Demo.ViewModels.Browse
{
    public class CreatePartVm
    {
        [Required]
        public PartType PartType { get; set; }

        [Required, StringLength(120)]
        public string Name { get; set; } = "";

        [Required, StringLength(80)]
        public string Brand { get; set; } = "";

        [Range(0, 100000)]
        public decimal Price { get; set; }

        [StringLength(4000)]
        public string? Description { get; set; }

        [StringLength(400)]
        public string? ImageUrl { get; set; }

        // CPU/Motherboard
        public string? Socket { get; set; }

        // CPU
        public int? Cores { get; set; }
        public float? ClockSpeedGHz { get; set; }

        // GPU
        public int? MemoryGB { get; set; }
        public string? Chipset { get; set; }

        // RAM/Storage
        public int? CapacityGB { get; set; }

        // RAM
        public string? RamType { get; set; }
        public int? SpeedMHz { get; set; }

        // Motherboard/Case
        public string? FormFactor { get; set; }

        // PSU
        public int? Wattage { get; set; }
        public string? Efficiency { get; set; }

        // Storage
        public string? StorageType { get; set; }

        // Case
        public string? Color { get; set; }
    }
}
