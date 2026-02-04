using Demo.Controllers;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Demo.Models.ViewModels.Browse
{
    public class BrowseIndexVm
    {
        public BrowseFilterVm Filter { get; set; } = new();
        public List<BrowseItemVm> Items { get; set; } = new();
        public List<SelectListItem> BrandOptions { get; set; } = new();
    }
}
