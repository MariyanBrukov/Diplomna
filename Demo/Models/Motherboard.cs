using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class Motherboard
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Socket { get; set; }

        [Display(Name = "Form Factor")]
        public string FormFactor { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
}
