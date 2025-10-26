using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class Case
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name = "Form Factor")]
        public string FormFactor { get; set; }

        public string Color { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
}
