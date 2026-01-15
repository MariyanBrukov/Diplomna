using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class Case : PartBase
    {
        [Display(Name = "Form Factor")]
        public string FormFactor { get; set; } = string.Empty;

        public string Color { get; set; } = string.Empty;
    }
}
