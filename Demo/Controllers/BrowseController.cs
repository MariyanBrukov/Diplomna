using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Demo.Models;
using Demo.ViewModels.Browse;

namespace Demo.Controllers
{
    public class BrowseController : Controller
    {
        private readonly ApplicationDbContext _db;

        public BrowseController(ApplicationDbContext db)
        {
            _db = db;
        }

        // /Browse?partType=CPU&minPrice=100&maxPrice=500&brand=Intel&coresMin=6
        [HttpGet]
        public async Task<IActionResult> Index([FromQuery] BrowseFilterVm filter)
        {
            // Default to CPU if not provided
            if (!filter.PartType.HasValue)
                filter.PartType = PartType.CPU;

            var itemsQuery = BuildFilteredQuery(filter);

            var brands = await GetBrandsForPartTypeAsync(filter.PartType.Value);

            var vm = new BrowseIndexVm
            {
                Filter = filter,
                Items = await itemsQuery
                    .OrderBy(x => x.Price)
                    .ThenBy(x => x.Name)
                    .ToListAsync(),
                BrandOptions = brands
                    .Select(b => new SelectListItem { Value = b, Text = b })
                    .ToList()
            };

            return View(vm);
        }

        // /Browse/Details?partType=GPU&id=5
        [HttpGet]
        public async Task<IActionResult> Details(PartType partType, int id)
        {
            var details = await LoadDetailsAsync(partType, id);
            if (details == null) return NotFound();

            return View(details);
        }

        // /Browse/Create?partType=CPU
        [HttpGet]
        public IActionResult Create(PartType partType)
        {
            var vm = new CreatePartVm
            {
                PartType = partType
            };

            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreatePartVm vm)
        {
            if (!ModelState.IsValid)
                return View(vm);

            switch (vm.PartType)
            {
                case PartType.CPU:
                    _db.CPUs.Add(new CPU
                    {
                        Name = vm.Name,
                        Brand = vm.Brand,
                        Description = vm.Description,
                        ImageUrl = vm.ImageUrl,
                        Price = vm.Price,
                        Socket = vm.Socket ?? "",
                        Cores = vm.Cores ?? 0,
                        ClockSpeedGHz = vm.ClockSpeedGHz ?? 0
                    });
                    break;

                case PartType.GPU:
                    _db.GPUs.Add(new GPU
                    {
                        Name = vm.Name,
                        Brand = vm.Brand,
                        Description = vm.Description,
                        ImageUrl = vm.ImageUrl,
                        Price = vm.Price,
                        MemoryGB = vm.MemoryGB ?? 0,
                        Chipset = vm.Chipset ?? ""
                    });
                    break;

                case PartType.RAM:
                    _db.RAMs.Add(new RAM
                    {
                        Name = vm.Name,
                        Brand = vm.Brand,
                        Description = vm.Description,
                        ImageUrl = vm.ImageUrl,
                        Price = vm.Price,
                        CapacityGB = vm.CapacityGB ?? 0,
                        Type = vm.RamType ?? "",
                        SpeedMHz = vm.SpeedMHz ?? 0
                    });
                    break;

                case PartType.Motherboard:
                    _db.Motherboards.Add(new Motherboard
                    {
                        Name = vm.Name,
                        Brand = vm.Brand,
                        Description = vm.Description,
                        ImageUrl = vm.ImageUrl,
                        Price = vm.Price,
                        Socket = vm.Socket ?? "",
                        FormFactor = vm.FormFactor ?? ""
                    });
                    break;

                case PartType.PowerSupply:
                    _db.PowerSupplies.Add(new PowerSupply
                    {
                        Name = vm.Name,
                        Brand = vm.Brand,
                        Description = vm.Description,
                        ImageUrl = vm.ImageUrl,
                        Price = vm.Price,
                        Wattage = vm.Wattage ?? 0,
                        Efficiency = vm.Efficiency ?? ""
                    });
                    break;

                case PartType.Storage:
                    _db.Storages.Add(new Storage
                    {
                        Name = vm.Name,
                        Brand = vm.Brand,
                        Description = vm.Description,
                        ImageUrl = vm.ImageUrl,
                        Price = vm.Price,
                        Type = vm.StorageType ?? "",
                        CapacityGB = vm.CapacityGB ?? 0
                    });
                    break;

                case PartType.Case:
                    _db.Cases.Add(new Case
                    {
                        Name = vm.Name,
                        Brand = vm.Brand,
                        Description = vm.Description,
                        ImageUrl = vm.ImageUrl,
                        Price = vm.Price,
                        FormFactor = vm.FormFactor ?? "",
                        Color = vm.Color ?? ""
                    });
                    break;

                default:
                    return BadRequest("Unsupported part type.");
            }

            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index), new { partType = vm.PartType });
        }

        // ============================================================
        // Helpers
        // ============================================================

        private IQueryable<BrowseItemVm> BuildFilteredQuery(BrowseFilterVm f)
        {
            bool HasMin() => f.MinPrice.HasValue;
            bool HasMax() => f.MaxPrice.HasValue;
            bool HasBrand() => !string.IsNullOrWhiteSpace(f.Brand);

            switch (f.PartType)
            {
                case PartType.CPU:
                    {
                        var q = _db.CPUs.AsNoTracking().Where(x => x.IsActive);

                        if (HasMin()) q = q.Where(x => x.Price >= f.MinPrice!.Value);
                        if (HasMax()) q = q.Where(x => x.Price <= f.MaxPrice!.Value);
                        if (HasBrand()) q = q.Where(x => x.Brand == f.Brand);

                        if (f.CoresMin.HasValue) q = q.Where(x => x.Cores >= f.CoresMin.Value);
                        if (!string.IsNullOrWhiteSpace(f.Socket)) q = q.Where(x => x.Socket == f.Socket);

                        return q.Select(x => new BrowseItemVm
                        {
                            PartType = PartType.CPU,
                            Id = x.Id,
                            Name = x.Name,
                            Brand = x.Brand,
                            Price = x.Price,
                            ImageUrl = x.ImageUrl,
                            ShortSpec = $"{x.Cores}C • {x.Socket}"
                        });
                    }

                case PartType.GPU:
                    {
                        var q = _db.GPUs.AsNoTracking().Where(x => x.IsActive);

                        if (HasMin()) q = q.Where(x => x.Price >= f.MinPrice!.Value);
                        if (HasMax()) q = q.Where(x => x.Price <= f.MaxPrice!.Value);
                        if (HasBrand()) q = q.Where(x => x.Brand == f.Brand);

                        if (f.MemoryGBMin.HasValue) q = q.Where(x => x.MemoryGB >= f.MemoryGBMin.Value);
                        if (!string.IsNullOrWhiteSpace(f.Chipset)) q = q.Where(x => x.Chipset.Contains(f.Chipset));

                        return q.Select(x => new BrowseItemVm
                        {
                            PartType = PartType.GPU,
                            Id = x.Id,
                            Name = x.Name,
                            Brand = x.Brand,
                            Price = x.Price,
                            ImageUrl = x.ImageUrl,
                            ShortSpec = $"{x.MemoryGB}GB • {x.Chipset}"
                        });
                    }

                case PartType.RAM:
                    {
                        var q = _db.RAMs.AsNoTracking().Where(x => x.IsActive);

                        if (HasMin()) q = q.Where(x => x.Price >= f.MinPrice!.Value);
                        if (HasMax()) q = q.Where(x => x.Price <= f.MaxPrice!.Value);
                        if (HasBrand()) q = q.Where(x => x.Brand == f.Brand);

                        if (f.CapacityGBMin.HasValue) q = q.Where(x => x.CapacityGB >= f.CapacityGBMin.Value);
                        if (!string.IsNullOrWhiteSpace(f.RamType)) q = q.Where(x => x.Type == f.RamType);
                        if (f.SpeedMHzMin.HasValue) q = q.Where(x => x.SpeedMHz >= f.SpeedMHzMin.Value);

                        return q.Select(x => new BrowseItemVm
                        {
                            PartType = PartType.RAM,
                            Id = x.Id,
                            Name = x.Name,
                            Brand = x.Brand,
                            Price = x.Price,
                            ImageUrl = x.ImageUrl,
                            ShortSpec = $"{x.CapacityGB}GB • {x.Type} • {x.SpeedMHz}MHz"
                        });
                    }

                case PartType.Motherboard:
                    {
                        var q = _db.Motherboards.AsNoTracking().Where(x => x.IsActive);

                        if (HasMin()) q = q.Where(x => x.Price >= f.MinPrice!.Value);
                        if (HasMax()) q = q.Where(x => x.Price <= f.MaxPrice!.Value);
                        if (HasBrand()) q = q.Where(x => x.Brand == f.Brand);

                        if (!string.IsNullOrWhiteSpace(f.Socket)) q = q.Where(x => x.Socket == f.Socket);
                        if (!string.IsNullOrWhiteSpace(f.FormFactor)) q = q.Where(x => x.FormFactor == f.FormFactor);

                        return q.Select(x => new BrowseItemVm
                        {
                            PartType = PartType.Motherboard,
                            Id = x.Id,
                            Name = x.Name,
                            Brand = x.Brand,
                            Price = x.Price,
                            ImageUrl = x.ImageUrl,
                            ShortSpec = $"{x.Socket} • {x.FormFactor}"
                        });
                    }

                case PartType.PowerSupply:
                    {
                        var q = _db.PowerSupplies.AsNoTracking().Where(x => x.IsActive);

                        if (HasMin()) q = q.Where(x => x.Price >= f.MinPrice!.Value);
                        if (HasMax()) q = q.Where(x => x.Price <= f.MaxPrice!.Value);
                        if (HasBrand()) q = q.Where(x => x.Brand == f.Brand);

                        if (f.WattageMin.HasValue) q = q.Where(x => x.Wattage >= f.WattageMin.Value);
                        if (!string.IsNullOrWhiteSpace(f.Efficiency)) q = q.Where(x => x.Efficiency == f.Efficiency);

                        return q.Select(x => new BrowseItemVm
                        {
                            PartType = PartType.PowerSupply,
                            Id = x.Id,
                            Name = x.Name,
                            Brand = x.Brand,
                            Price = x.Price,
                            ImageUrl = x.ImageUrl,
                            ShortSpec = $"{x.Wattage}W • {x.Efficiency}"
                        });
                    }

                case PartType.Storage:
                    {
                        var q = _db.Storages.AsNoTracking().Where(x => x.IsActive);

                        if (HasMin()) q = q.Where(x => x.Price >= f.MinPrice!.Value);
                        if (HasMax()) q = q.Where(x => x.Price <= f.MaxPrice!.Value);
                        if (HasBrand()) q = q.Where(x => x.Brand == f.Brand);

                        if (!string.IsNullOrWhiteSpace(f.StorageType)) q = q.Where(x => x.Type == f.StorageType);
                        if (f.CapacityGBMin.HasValue) q = q.Where(x => x.CapacityGB >= f.CapacityGBMin.Value);

                        return q.Select(x => new BrowseItemVm
                        {
                            PartType = PartType.Storage,
                            Id = x.Id,
                            Name = x.Name,
                            Brand = x.Brand,
                            Price = x.Price,
                            ImageUrl = x.ImageUrl,
                            ShortSpec = $"{x.CapacityGB}GB • {x.Type}"
                        });
                    }

                case PartType.Case:
                    {
                        var q = _db.Cases.AsNoTracking().Where(x => x.IsActive);

                        if (HasMin()) q = q.Where(x => x.Price >= f.MinPrice!.Value);
                        if (HasMax()) q = q.Where(x => x.Price <= f.MaxPrice!.Value);
                        if (HasBrand()) q = q.Where(x => x.Brand == f.Brand);

                        if (!string.IsNullOrWhiteSpace(f.FormFactor)) q = q.Where(x => x.FormFactor == f.FormFactor);
                        if (!string.IsNullOrWhiteSpace(f.Color)) q = q.Where(x => x.Color == f.Color);

                        return q.Select(x => new BrowseItemVm
                        {
                            PartType = PartType.Case,
                            Id = x.Id,
                            Name = x.Name,
                            Brand = x.Brand,
                            Price = x.Price,
                            ImageUrl = x.ImageUrl,
                            ShortSpec = $"{x.FormFactor} • {x.Color}"
                        });
                    }

                default:
                    return Enumerable.Empty<BrowseItemVm>().AsQueryable();
            }
        }

        private async Task<List<string>> GetBrandsForPartTypeAsync(PartType partType)
        {
            IQueryable<string> q = partType switch
            {
                PartType.CPU => _db.CPUs.Where(x => x.IsActive).Select(x => x.Brand),
                PartType.GPU => _db.GPUs.Where(x => x.IsActive).Select(x => x.Brand),
                PartType.RAM => _db.RAMs.Where(x => x.IsActive).Select(x => x.Brand),
                PartType.Motherboard => _db.Motherboards.Where(x => x.IsActive).Select(x => x.Brand),
                PartType.PowerSupply => _db.PowerSupplies.Where(x => x.IsActive).Select(x => x.Brand),
                PartType.Storage => _db.Storages.Where(x => x.IsActive).Select(x => x.Brand),
                PartType.Case => _db.Cases.Where(x => x.IsActive).Select(x => x.Brand),
                _ => Enumerable.Empty<string>().AsQueryable()
            };

            return await q
                .Where(b => b != null && b != "")
                .Distinct()
                .OrderBy(b => b)
                .ToListAsync();
        }

        private async Task<PartDetailsVm?> LoadDetailsAsync(PartType partType, int id)
        {
            switch (partType)
            {
                case PartType.CPU:
                    {
                        var x = await _db.CPUs.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id && p.IsActive);
                        if (x == null) return null;
                        return new PartDetailsVm
                        {
                            PartType = partType,
                            Id = x.Id,
                            Name = x.Name,
                            Brand = x.Brand,
                            Description = x.Description,
                            ImageUrl = x.ImageUrl,
                            Price = x.Price,
                            Specs = new Dictionary<string, string>
                            {
                                ["Socket"] = x.Socket,
                                ["Cores"] = x.Cores.ToString(),
                                ["Clock (GHz)"] = x.ClockSpeedGHz.ToString()
                            }
                        };
                    }

                case PartType.GPU:
                    {
                        var x = await _db.GPUs.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id && p.IsActive);
                        if (x == null) return null;
                        return new PartDetailsVm
                        {
                            PartType = partType,
                            Id = x.Id,
                            Name = x.Name,
                            Brand = x.Brand,
                            Description = x.Description,
                            ImageUrl = x.ImageUrl,
                            Price = x.Price,
                            Specs = new Dictionary<string, string>
                            {
                                ["Memory (GB)"] = x.MemoryGB.ToString(),
                                ["Chipset"] = x.Chipset
                            }
                        };
                    }

                case PartType.RAM:
                    {
                        var x = await _db.RAMs.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id && p.IsActive);
                        if (x == null) return null;
                        return new PartDetailsVm
                        {
                            PartType = partType,
                            Id = x.Id,
                            Name = x.Name,
                            Brand = x.Brand,
                            Description = x.Description,
                            ImageUrl = x.ImageUrl,
                            Price = x.Price,
                            Specs = new Dictionary<string, string>
                            {
                                ["Capacity (GB)"] = x.CapacityGB.ToString(),
                                ["Type"] = x.Type,
                                ["Speed (MHz)"] = x.SpeedMHz.ToString()
                            }
                        };
                    }

                case PartType.Motherboard:
                    {
                        var x = await _db.Motherboards.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id && p.IsActive);
                        if (x == null) return null;
                        return new PartDetailsVm
                        {
                            PartType = partType,
                            Id = x.Id,
                            Name = x.Name,
                            Brand = x.Brand,
                            Description = x.Description,
                            ImageUrl = x.ImageUrl,
                            Price = x.Price,
                            Specs = new Dictionary<string, string>
                            {
                                ["Socket"] = x.Socket,
                                ["Form Factor"] = x.FormFactor
                            }
                        };
                    }

                case PartType.PowerSupply:
                    {
                        var x = await _db.PowerSupplies.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id && p.IsActive);
                        if (x == null) return null;
                        return new PartDetailsVm
                        {
                            PartType = partType,
                            Id = x.Id,
                            Name = x.Name,
                            Brand = x.Brand,
                            Description = x.Description,
                            ImageUrl = x.ImageUrl,
                            Price = x.Price,
                            Specs = new Dictionary<string, string>
                            {
                                ["Wattage"] = x.Wattage.ToString(),
                                ["Efficiency"] = x.Efficiency
                            }
                        };
                    }

                case PartType.Storage:
                    {
                        var x = await _db.Storages.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id && p.IsActive);
                        if (x == null) return null;
                        return new PartDetailsVm
                        {
                            PartType = partType,
                            Id = x.Id,
                            Name = x.Name,
                            Brand = x.Brand,
                            Description = x.Description,
                            ImageUrl = x.ImageUrl,
                            Price = x.Price,
                            Specs = new Dictionary<string, string>
                            {
                                ["Type"] = x.Type,
                                ["Capacity (GB)"] = x.CapacityGB.ToString()
                            }
                        };
                    }

                case PartType.Case:
                    {
                        var x = await _db.Cases.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id && p.IsActive);
                        if (x == null) return null;
                        return new PartDetailsVm
                        {
                            PartType = partType,
                            Id = x.Id,
                            Name = x.Name,
                            Brand = x.Brand,
                            Description = x.Description,
                            ImageUrl = x.ImageUrl,
                            Price = x.Price,
                            Specs = new Dictionary<string, string>
                            {
                                ["Form Factor"] = x.FormFactor,
                                ["Color"] = x.Color
                            }
                        };
                    }

                default:
                    return null;
            }
        }
    }
}
