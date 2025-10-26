using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class CPU
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Socket { get; set; }

        public int Cores { get; set; }

        [Display(Name = "Clock Speed (GHz)")]
        public float ClockSpeedGHz { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
}
