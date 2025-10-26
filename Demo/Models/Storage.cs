using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class Storage
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Type { get; set; } // SSD, HDD, NVMe

        [Display(Name = "Capacity (GB)")]
        public int CapacityGB { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
}
