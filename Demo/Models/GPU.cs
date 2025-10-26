using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class GPU
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name = "Memory (GB)")]
        public int MemoryGB { get; set; }

        public string Chipset { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
}
