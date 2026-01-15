using Demo.Models;

namespace Demo.ViewModels.Browse
{
    public class PartDetailsVm
    {
        public PartType PartType { get; set; }
        public int Id { get; set; }

        public string Name { get; set; } = "";
        public string Brand { get; set; } = "";
        public decimal Price { get; set; }

        public string? Description { get; set; }
        public string? ImageUrl { get; set; }

        public Dictionary<string, string> Specs { get; set; } = new();
    }
}
