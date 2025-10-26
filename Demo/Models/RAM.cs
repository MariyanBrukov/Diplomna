using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class RAM
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name = "Capacity (GB)")]
        public int CapacityGB { get; set; }

        public string Type { get; set; }

        [Display(Name = "Speed (MHz)")]
        public int SpeedMHz { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
}
