using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class Storage : PartBase
    {
        [Required]
        public string Type { get; set; } = string.Empty; // SSD, HDD, NVMe

        [Display(Name = "Capacity (GB)")]
        public int CapacityGB { get; set; }
    }
}
