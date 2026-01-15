using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class GPU : PartBase
    {
        [Display(Name = "Memory (GB)")]
        public int MemoryGB { get; set; }

        public string Chipset { get; set; } = string.Empty;
    }
}
