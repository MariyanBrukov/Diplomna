using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Demo.Models;
using Demo.Models.ViewModels.Browse;

namespace Demo.Controllers
{
    public class BrowseController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IWebHostEnvironment _env;

        public BrowseController(ApplicationDbContext db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }

        // /Browse?partType=CPU&minPrice=100&maxPrice=500&brand=Intel&coresMin=6&search=ryzen&sort=price_desc
        [HttpGet]
        public async Task<IActionResult> Index([FromQuery] BrowseFilterVm filter)
        {
            if (!filter.PartType.HasValue)
                filter.PartType = PartType.CPU;

            var q = BuildFilteredQuery(filter);
            q = ApplySorting(q, filter.Sort);

            var brands = await GetBrandsForPartTypeAsync(filter.PartType.Value);

            var vm = new BrowseIndexVm
            {
                Filter = filter,
                Items = await q.ToListAsync(),
                BrandOptions = brands.Select(b => new SelectListItem { Value = b, Text = b }).ToList()
            };

            return View(vm);
        }

        [HttpGet]
        public async Task<IActionResult> Details(PartType partType, int id)
        {
            var details = await LoadDetailsAsync(partType, id);
            if (details == null) return NotFound();
            return View(details);
        }

        // ---------------------------
        // CREATE (GET)
        // ---------------------------
        [HttpGet]
        public IActionResult Create(PartType partType)
        {
            return View(new CreatePartVm { PartType = partType });
        }

        // ---------------------------
        // CREATE (POST) + Upload
        // ---------------------------
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreatePartVm vm)
        {
            if (!ModelState.IsValid)
                return View(vm);

            // If you upgraded CreatePartVm to include ImageFile:
            // - if ImageFile is provided, save and use it
            // - else keep vm.ImageUrl (if you still allow URL)
            if (vm.ImageFile != null && vm.ImageFile.Length > 0)
            {
                try
                {
                    vm.ImageUrl = await SavePartImageAsync(vm.PartType, vm.ImageFile);
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(nameof(vm.ImageFile), "Upload failed: " + ex.Message);
                    return View(vm);
                }
            }

            switch (vm.PartType)
            {
                case PartType.CPU:
                    _db.CPUs.Add(new CPU
                    {
                        Name = vm.Name,
                        Brand = vm.Brand,
                        Price = vm.Price,
                        Description = vm.Description,          // ✅ important
                        ImageUrl = vm.ImageUrl,
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
                        Price = vm.Price,
                        Description = vm.Description,          // ✅ important
                        ImageUrl = vm.ImageUrl,
                        MemoryGB = vm.MemoryGB ?? 0,
                        Chipset = vm.Chipset ?? ""
                    });
                    break;

                case PartType.RAM:
                    _db.RAMs.Add(new RAM
                    {
                        Name = vm.Name,
                        Brand = vm.Brand,
                        Price = vm.Price,
                        Description = vm.Description,          // ✅ important
                        ImageUrl = vm.ImageUrl,
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
                        Price = vm.Price,
                        Description = vm.Description,          // ✅ important
                        ImageUrl = vm.ImageUrl,
                        Socket = vm.Socket ?? "",
                        FormFactor = vm.FormFactor ?? ""
                    });
                    break;

                case PartType.PowerSupply:
                    _db.PowerSupplies.Add(new PowerSupply
                    {
                        Name = vm.Name,
                        Brand = vm.Brand,
                        Price = vm.Price,
                        Description = vm.Description,          // ✅ important
                        ImageUrl = vm.ImageUrl,
                        Wattage = vm.Wattage ?? 0,
                        Efficiency = vm.Efficiency ?? ""
                    });
                    break;

                case PartType.Storage:
                    _db.Storages.Add(new Storage
                    {
                        Name = vm.Name,
                        Brand = vm.Brand,
                        Price = vm.Price,
                        Description = vm.Description,          // ✅ important
                        ImageUrl = vm.ImageUrl,
                        Type = vm.StorageType ?? "",
                        CapacityGB = vm.CapacityGB ?? 0
                    });
                    break;

                case PartType.Case:
                    _db.Cases.Add(new Case
                    {
                        Name = vm.Name,
                        Brand = vm.Brand,
                        Price = vm.Price,
                        Description = vm.Description,          // ✅ important
                        ImageUrl = vm.ImageUrl,
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

        // ---------------------------
        // EDIT (GET)
        // ---------------------------
        [HttpGet]
        public async Task<IActionResult> Edit(PartType partType, int id)
        {
            var vm = await LoadEditVmAsync(partType, id);
            if (vm == null) return NotFound();
            return View(vm);
        }

        // ---------------------------
        // EDIT (POST) + Upload
        // ---------------------------
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EditPartVm vm)
        {
            if (!ModelState.IsValid)
                return View(vm);

            string? imageUrl = vm.ExistingImageUrl;

            if (vm.ImageFile != null && vm.ImageFile.Length > 0)
            {
                try
                {
                    imageUrl = await SavePartImageAsync(vm.PartType, vm.ImageFile);
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(nameof(vm.ImageFile), "Upload failed: " + ex.Message);
                    vm.ExistingImageUrl = imageUrl;
                    return View(vm);
                }
            }

            switch (vm.PartType)
            {
                case PartType.CPU:
                    {
                        var x = await _db.CPUs.FirstOrDefaultAsync(p => p.Id == vm.Id);
                        if (x == null) return NotFound();

                        x.Name = vm.Name;
                        x.Brand = vm.Brand;
                        x.Price = vm.Price;
                        x.Description = vm.Description;          // ✅ important
                        x.ImageUrl = imageUrl;
                        x.Socket = vm.Socket ?? "";
                        x.Cores = vm.Cores ?? 0;
                        x.ClockSpeedGHz = vm.ClockSpeedGHz ?? 0;
                        break;
                    }

                case PartType.GPU:
                    {
                        var x = await _db.GPUs.FirstOrDefaultAsync(p => p.Id == vm.Id);
                        if (x == null) return NotFound();

                        x.Name = vm.Name;
                        x.Brand = vm.Brand;
                        x.Price = vm.Price;
                        x.Description = vm.Description;          // ✅ important
                        x.ImageUrl = imageUrl;
                        x.MemoryGB = vm.MemoryGB ?? 0;
                        x.Chipset = vm.Chipset ?? "";
                        break;
                    }

                case PartType.RAM:
                    {
                        var x = await _db.RAMs.FirstOrDefaultAsync(p => p.Id == vm.Id);
                        if (x == null) return NotFound();

                        x.Name = vm.Name;
                        x.Brand = vm.Brand;
                        x.Price = vm.Price;
                        x.Description = vm.Description;          // ✅ important
                        x.ImageUrl = imageUrl;
                        x.CapacityGB = vm.CapacityGB ?? 0;
                        x.Type = vm.RamType ?? "";
                        x.SpeedMHz = vm.SpeedMHz ?? 0;
                        break;
                    }

                case PartType.Motherboard:
                    {
                        var x = await _db.Motherboards.FirstOrDefaultAsync(p => p.Id == vm.Id);
                        if (x == null) return NotFound();

                        x.Name = vm.Name;
                        x.Brand = vm.Brand;
                        x.Price = vm.Price;
                        x.Description = vm.Description;          // ✅ important
                        x.ImageUrl = imageUrl;
                        x.Socket = vm.Socket ?? "";
                        x.FormFactor = vm.FormFactor ?? "";
                        break;
                    }

                case PartType.PowerSupply:
                    {
                        var x = await _db.PowerSupplies.FirstOrDefaultAsync(p => p.Id == vm.Id);
                        if (x == null) return NotFound();

                        x.Name = vm.Name;
                        x.Brand = vm.Brand;
                        x.Price = vm.Price;
                        x.Description = vm.Description;          // ✅ important
                        x.ImageUrl = imageUrl;
                        x.Wattage = vm.Wattage ?? 0;
                        x.Efficiency = vm.Efficiency ?? "";
                        break;
                    }

                case PartType.Storage:
                    {
                        var x = await _db.Storages.FirstOrDefaultAsync(p => p.Id == vm.Id);
                        if (x == null) return NotFound();

                        x.Name = vm.Name;
                        x.Brand = vm.Brand;
                        x.Price = vm.Price;
                        x.Description = vm.Description;          // ✅ important
                        x.ImageUrl = imageUrl;
                        x.Type = vm.StorageType ?? "";
                        x.CapacityGB = vm.CapacityGB ?? 0;
                        break;
                    }

                case PartType.Case:
                    {
                        var x = await _db.Cases.FirstOrDefaultAsync(p => p.Id == vm.Id);
                        if (x == null) return NotFound();

                        x.Name = vm.Name;
                        x.Brand = vm.Brand;
                        x.Price = vm.Price;
                        x.Description = vm.Description;          // ✅ important
                        x.ImageUrl = imageUrl;
                        x.FormFactor = vm.FormFactor ?? "";
                        x.Color = vm.Color ?? "";
                        break;
                    }

                default:
                    return BadRequest("Unsupported part type.");
            }

            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Details), new { partType = vm.PartType, id = vm.Id });
        }

        // ============================================================
        // Helpers
        // ============================================================

        private static IQueryable<BrowseItemVm> ApplySorting(IQueryable<BrowseItemVm> q, string? sort)
        {
            return sort switch
            {
                "price_desc" => q.OrderByDescending(x => x.Price).ThenBy(x => x.Name),
                "name_asc" => q.OrderBy(x => x.Name),
                "price_asc" => q.OrderBy(x => x.Price).ThenBy(x => x.Name),
                "name_desc" => q.OrderByDescending(x => x.Name),
                _ => q.OrderBy(x => x.Price).ThenBy(x => x.Name)
            };
        }

        private IQueryable<BrowseItemVm> BuildFilteredQuery(BrowseFilterVm f)
        {
            bool HasMin() => f.MinPrice.HasValue;
            bool HasMax() => f.MaxPrice.HasValue;
            bool HasBrand() => !string.IsNullOrWhiteSpace(f.Brand);
            bool HasSearch() => !string.IsNullOrWhiteSpace(f.Search);

            switch (f.PartType)
            {
                case PartType.CPU:
                    {
                        var q = _db.CPUs.AsNoTracking().Where(x => x.IsActive);

                        if (HasMin()) q = q.Where(x => x.Price >= f.MinPrice!.Value);
                        if (HasMax()) q = q.Where(x => x.Price <= f.MaxPrice!.Value);
                        if (HasBrand()) q = q.Where(x => x.Brand == f.Brand);
                        if (HasSearch()) q = q.Where(x => x.Name.Contains(f.Search!));

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
                        if (HasSearch()) q = q.Where(x => x.Name.Contains(f.Search!));

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
                        if (HasSearch()) q = q.Where(x => x.Name.Contains(f.Search!));

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
                        if (HasSearch()) q = q.Where(x => x.Name.Contains(f.Search!));

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
                        if (HasSearch()) q = q.Where(x => x.Name.Contains(f.Search!));

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
                        if (HasSearch()) q = q.Where(x => x.Name.Contains(f.Search!));

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
                        if (HasSearch()) q = q.Where(x => x.Name.Contains(f.Search!));

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

        // ✅ IMPORTANT: now returns specs too, so Details page can show them
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

        private async Task<EditPartVm?> LoadEditVmAsync(PartType partType, int id)
        {
            switch (partType)
            {
                case PartType.CPU:
                    {
                        var x = await _db.CPUs.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
                        if (x == null) return null;

                        return new EditPartVm
                        {
                            PartType = partType,
                            Id = x.Id,
                            Name = x.Name,
                            Brand = x.Brand,
                            Price = x.Price,
                            Description = x.Description,              // ✅ important
                            ExistingImageUrl = x.ImageUrl,
                            Socket = x.Socket,
                            Cores = x.Cores,
                            ClockSpeedGHz = x.ClockSpeedGHz
                        };
                    }

                case PartType.GPU:
                    {
                        var x = await _db.GPUs.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
                        if (x == null) return null;

                        return new EditPartVm
                        {
                            PartType = partType,
                            Id = x.Id,
                            Name = x.Name,
                            Brand = x.Brand,
                            Price = x.Price,
                            Description = x.Description,              // ✅ important
                            ExistingImageUrl = x.ImageUrl,
                            MemoryGB = x.MemoryGB,
                            Chipset = x.Chipset
                        };
                    }

                case PartType.RAM:
                    {
                        var x = await _db.RAMs.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
                        if (x == null) return null;

                        return new EditPartVm
                        {
                            PartType = partType,
                            Id = x.Id,
                            Name = x.Name,
                            Brand = x.Brand,
                            Price = x.Price,
                            Description = x.Description,              // ✅ important
                            ExistingImageUrl = x.ImageUrl,
                            CapacityGB = x.CapacityGB,
                            RamType = x.Type,
                            SpeedMHz = x.SpeedMHz
                        };
                    }

                case PartType.Motherboard:
                    {
                        var x = await _db.Motherboards.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
                        if (x == null) return null;

                        return new EditPartVm
                        {
                            PartType = partType,
                            Id = x.Id,
                            Name = x.Name,
                            Brand = x.Brand,
                            Price = x.Price,
                            Description = x.Description,              // ✅ important
                            ExistingImageUrl = x.ImageUrl,
                            Socket = x.Socket,
                            FormFactor = x.FormFactor
                        };
                    }

                case PartType.PowerSupply:
                    {
                        var x = await _db.PowerSupplies.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
                        if (x == null) return null;

                        return new EditPartVm
                        {
                            PartType = partType,
                            Id = x.Id,
                            Name = x.Name,
                            Brand = x.Brand,
                            Price = x.Price,
                            Description = x.Description,              // ✅ important
                            ExistingImageUrl = x.ImageUrl,
                            Wattage = x.Wattage,
                            Efficiency = x.Efficiency
                        };
                    }

                case PartType.Storage:
                    {
                        var x = await _db.Storages.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
                        if (x == null) return null;

                        return new EditPartVm
                        {
                            PartType = partType,
                            Id = x.Id,
                            Name = x.Name,
                            Brand = x.Brand,
                            Price = x.Price,
                            Description = x.Description,              // ✅ important
                            ExistingImageUrl = x.ImageUrl,
                            StorageType = x.Type,
                            CapacityGB = x.CapacityGB
                        };
                    }

                case PartType.Case:
                    {
                        var x = await _db.Cases.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
                        if (x == null) return null;

                        return new EditPartVm
                        {
                            PartType = partType,
                            Id = x.Id,
                            Name = x.Name,
                            Brand = x.Brand,
                            Price = x.Price,
                            Description = x.Description,              // ✅ important
                            ExistingImageUrl = x.ImageUrl,
                            FormFactor = x.FormFactor,
                            Color = x.Color
                        };
                    }

                default:
                    return null;
            }
        }

        private async Task<string> SavePartImageAsync(PartType partType, IFormFile file)
        {
            if (file == null || file.Length == 0)
                throw new InvalidOperationException("No file uploaded.");

            var allowed = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            {
                ".jpg", ".jpeg", ".png", ".webp"
            };

            var ext = Path.GetExtension(file.FileName);
            if (string.IsNullOrWhiteSpace(ext) || !allowed.Contains(ext))
                throw new InvalidOperationException("Only JPG, PNG, or WEBP images allowed.");

            var webRoot = _env.WebRootPath;
            if (string.IsNullOrWhiteSpace(webRoot))
                webRoot = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");

            var folderName = partType.ToString().ToLowerInvariant();
            var relDir = Path.Combine("images", "parts", folderName);
            var absDir = Path.Combine(webRoot, relDir);

            Directory.CreateDirectory(absDir);

            var fileName = $"{Guid.NewGuid():N}{ext}";
            var absPath = Path.Combine(absDir, fileName);

            using var stream = new FileStream(absPath, FileMode.Create, FileAccess.Write);
            await file.CopyToAsync(stream);

            return "/" + Path.Combine(relDir, fileName).Replace("\\", "/");
        }
    }
}