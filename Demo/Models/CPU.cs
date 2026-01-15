using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class CPU : PartBase
    {
        public string Socket { get; set; } = string.Empty;

        public int Cores { get; set; }

        [Display(Name = "Clock Speed (GHz)")]
        public float ClockSpeedGHz { get; set; }
    }
}
