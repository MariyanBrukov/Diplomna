using Demo.Models;

namespace Demo.ViewModels.Browse
{
    public class BrowseItemVm
    {
        public PartType PartType { get; set; }
        public int Id { get; set; }

        public string Name { get; set; } = "";
        public string Brand { get; set; } = "";
        public decimal Price { get; set; }

        public string? ImageUrl { get; set; }
        public string? ShortSpec { get; set; }
    }
}
