using System.ComponentModel.DataAnnotations;
using Demo.Models;

namespace Demo.ViewModels.Browse
{
    public class BrowseFilterVm
    {
        public PartType? PartType { get; set; }

        [Display(Name = "Min Price")]
        public decimal? MinPrice { get; set; }

        [Display(Name = "Max Price")]
        public decimal? MaxPrice { get; set; }

        public string? Brand { get; set; }

        // CPU + Motherboard
        public string? Socket { get; set; }

        // CPU
        [Display(Name = "Min Cores")]
        public int? CoresMin { get; set; }

        // GPU
        [Display(Name = "Min VRAM (GB)")]
        public int? MemoryGBMin { get; set; }

        public string? Chipset { get; set; }

        // RAM + Storage
        [Display(Name = "Min Capacity (GB)")]
        public int? CapacityGBMin { get; set; }

        // RAM
        [Display(Name = "RAM Type")]
        public string? RamType { get; set; }

        [Display(Name = "Min Speed (MHz)")]
        public int? SpeedMHzMin { get; set; }

        // Motherboard + Case
        public string? FormFactor { get; set; }

        // PSU
        [Display(Name = "Min Wattage")]
        public int? WattageMin { get; set; }

        public string? Efficiency { get; set; }

        // Storage
        [Display(Name = "Storage Type")]
        public string? StorageType { get; set; }

        // Case
        public string? Color { get; set; }
    }
}
