using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class PowerSupply
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name = "Wattage (W)")]
        public int Wattage { get; set; }

        public string Efficiency { get; set; } // 80+ Bronze, Gold, etc.

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
}
