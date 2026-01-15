using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class PowerSupply : PartBase
    {
        [Display(Name = "Wattage (W)")]
        public int Wattage { get; set; }

        public string Efficiency { get; set; } = string.Empty; // 80+ Bronze, Gold, etc.
    }
}
