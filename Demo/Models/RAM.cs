using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class RAM : PartBase
    {
        [Display(Name = "Capacity (GB)")]
        public int CapacityGB { get; set; }

        public string Type { get; set; } = string.Empty;

        [Display(Name = "Speed (MHz)")]
        public int SpeedMHz { get; set; }
    }
}

