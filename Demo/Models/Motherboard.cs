using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class Motherboard : PartBase
    {
        public string Socket { get; set; } = string.Empty;

        [Display(Name = "Form Factor")]
        public string FormFactor { get; set; } = string.Empty;
    }
}
