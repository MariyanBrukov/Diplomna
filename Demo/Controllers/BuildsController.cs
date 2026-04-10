using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Demo.Models;

namespace Demo.Controllers
{
    public class BuildsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BuildsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var userId = HttpContext.Session.GetInt32("UserId");
            if (userId == null)
                return RedirectToAction("Login", "Account");

            var builds = _context.Builds
                .Where(b => b.UserId == userId.Value)
                .Include(b => b.CPU)
                .Include(b => b.GPU)
                .Include(b => b.Motherboard)
                .Include(b => b.RAM)
                .Include(b => b.Storage)
                .Include(b => b.PowerSupply)
                .Include(b => b.Case);

            return View(await builds.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var userId = HttpContext.Session.GetInt32("UserId");
            if (userId == null)
                return RedirectToAction("Login", "Account");

            var build = await _context.Builds
                .Include(b => b.CPU)
                .Include(b => b.GPU)
                .Include(b => b.Motherboard)
                .Include(b => b.RAM)
                .Include(b => b.Storage)
                .Include(b => b.PowerSupply)
                .Include(b => b.Case)
                .FirstOrDefaultAsync(m => m.Id == id && m.UserId == userId.Value);

            if (build == null)
                return NotFound();

            return View(build);
        }

        public IActionResult Create()
        {
            var userId = HttpContext.Session.GetInt32("UserId");
            if (userId == null)
                return RedirectToAction("Login", "Account");

            PopulateDropdowns();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BuildName,CPUId,GPUId,MotherboardId,RAMId,StorageId,PowerSupplyId,CaseId")] Build build)
        {
            var userId = HttpContext.Session.GetInt32("UserId");
            if (userId == null)
                return RedirectToAction("Login", "Account");

            if (ModelState.IsValid)
            {
                build.UserId = userId.Value;
                build.TotalPrice = await CalculateTotalPrice(build);

                _context.Builds.Add(build);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            PopulateDropdowns(build);
            return View(build);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var userId = HttpContext.Session.GetInt32("UserId");
            if (userId == null)
                return RedirectToAction("Login", "Account");

            var build = await _context.Builds
                .FirstOrDefaultAsync(b => b.Id == id && b.UserId == userId.Value);

            if (build == null)
                return NotFound();

            PopulateDropdowns(build);
            return View(build);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,BuildName,CPUId,GPUId,MotherboardId,RAMId,StorageId,PowerSupplyId,CaseId")] Build build)
        {
            if (id != build.Id)
                return NotFound();

            var userId = HttpContext.Session.GetInt32("UserId");
            if (userId == null)
                return RedirectToAction("Login", "Account");

            var existingBuild = await _context.Builds
                .AsNoTracking()
                .FirstOrDefaultAsync(b => b.Id == id && b.UserId == userId.Value);

            if (existingBuild == null)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    build.UserId = userId.Value;
                    build.TotalPrice = await CalculateTotalPrice(build);

                    _context.Builds.Update(build);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BuildExists(build.Id))
                        return NotFound();
                    else
                        throw;
                }

                return RedirectToAction(nameof(Index));
            }

            PopulateDropdowns(build);
            return View(build);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var userId = HttpContext.Session.GetInt32("UserId");
            if (userId == null)
                return RedirectToAction("Login", "Account");

            var build = await _context.Builds
                .Include(b => b.CPU)
                .Include(b => b.GPU)
                .Include(b => b.Motherboard)
                .Include(b => b.RAM)
                .Include(b => b.Storage)
                .Include(b => b.PowerSupply)
                .Include(b => b.Case)
                .FirstOrDefaultAsync(m => m.Id == id && m.UserId == userId.Value);

            if (build == null)
                return NotFound();

            return View(build);
        }

        [HttpPost, ActionName("DeleteConfirmed")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userId = HttpContext.Session.GetInt32("UserId");
            if (userId == null)
                return RedirectToAction("Login", "Account");

            var build = await _context.Builds
                .FirstOrDefaultAsync(b => b.Id == id && b.UserId == userId.Value);

            if (build != null)
            {
                _context.Builds.Remove(build);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }

        private void PopulateDropdowns(Build? build = null)
        {
            var selectedCpuId = build?.CPUId;
            var selectedGpuId = build?.GPUId;
            var selectedMotherboardId = build?.MotherboardId;
            var selectedRamId = build?.RAMId;
            var selectedStorageId = build?.StorageId;
            var selectedPowerSupplyId = build?.PowerSupplyId;
            var selectedCaseId = build?.CaseId;

            var cpus = _context.CPUs
                .AsNoTracking()
                .Where(x => x.IsActive || (selectedCpuId.HasValue && x.Id == selectedCpuId.Value))
                .OrderBy(x => x.Name)
                .Select(x => new
                {
                    x.Id,
                    Display = x.Name + "|" + x.Price
                })
                .ToList();

            var gpus = _context.GPUs
                .AsNoTracking()
                .Where(x => x.IsActive || (selectedGpuId.HasValue && x.Id == selectedGpuId.Value))
                .OrderBy(x => x.Name)
                .Select(x => new
                {
                    x.Id,
                    Display = x.Name + "|" + x.Price
                })
                .ToList();

            var motherboards = _context.Motherboards
                .AsNoTracking()
                .Where(x => x.IsActive || (selectedMotherboardId.HasValue && x.Id == selectedMotherboardId.Value))
                .OrderBy(x => x.Name)
                .Select(x => new
                {
                    x.Id,
                    Display = x.Name + "|" + x.Price
                })
                .ToList();

            var rams = _context.RAMs
                .AsNoTracking()
                .Where(x => x.IsActive || (selectedRamId.HasValue && x.Id == selectedRamId.Value))
                .OrderBy(x => x.Name)
                .Select(x => new
                {
                    x.Id,
                    Display = x.Name + "|" + x.Price
                })
                .ToList();

            var storages = _context.Storages
                .AsNoTracking()
                .Where(x => x.IsActive || (selectedStorageId.HasValue && x.Id == selectedStorageId.Value))
                .OrderBy(x => x.Name)
                .Select(x => new
                {
                    x.Id,
                    Display = x.Name + "|" + x.Price
                })
                .ToList();

            var powerSupplies = _context.PowerSupplies
                .AsNoTracking()
                .Where(x => x.IsActive || (selectedPowerSupplyId.HasValue && x.Id == selectedPowerSupplyId.Value))
                .OrderBy(x => x.Name)
                .Select(x => new
                {
                    x.Id,
                    Display = x.Name + "|" + x.Price
                })
                .ToList();

            var cases = _context.Cases
                .AsNoTracking()
                .Where(x => x.IsActive || (selectedCaseId.HasValue && x.Id == selectedCaseId.Value))
                .OrderBy(x => x.Name)
                .Select(x => new
                {
                    x.Id,
                    Display = x.Name + "|" + x.Price
                })
                .ToList();

            ViewData["CPUId"] = new SelectList(cpus, "Id", "Display", selectedCpuId);
            ViewData["GPUId"] = new SelectList(gpus, "Id", "Display", selectedGpuId);
            ViewData["MotherboardId"] = new SelectList(motherboards, "Id", "Display", selectedMotherboardId);
            ViewData["RAMId"] = new SelectList(rams, "Id", "Display", selectedRamId);
            ViewData["StorageId"] = new SelectList(storages, "Id", "Display", selectedStorageId);
            ViewData["PowerSupplyId"] = new SelectList(powerSupplies, "Id", "Display", selectedPowerSupplyId);
            ViewData["CaseId"] = new SelectList(cases, "Id", "Display", selectedCaseId);
        }

        private async Task<decimal> CalculateTotalPrice(Build build)
        {
            decimal total = 0;

            var cpu = await _context.CPUs.FirstOrDefaultAsync(x => x.Id == build.CPUId && x.IsActive);
            var gpu = await _context.GPUs.FirstOrDefaultAsync(x => x.Id == build.GPUId && x.IsActive);
            var mb = await _context.Motherboards.FirstOrDefaultAsync(x => x.Id == build.MotherboardId && x.IsActive);
            var ram = await _context.RAMs.FirstOrDefaultAsync(x => x.Id == build.RAMId && x.IsActive);
            var storage = await _context.Storages.FirstOrDefaultAsync(x => x.Id == build.StorageId && x.IsActive);
            var ps = await _context.PowerSupplies.FirstOrDefaultAsync(x => x.Id == build.PowerSupplyId && x.IsActive);
            var pcCase = await _context.Cases.FirstOrDefaultAsync(x => x.Id == build.CaseId && x.IsActive);

            if (cpu != null) total += cpu.Price;
            if (gpu != null) total += gpu.Price;
            if (mb != null) total += mb.Price;
            if (ram != null) total += ram.Price;
            if (storage != null) total += storage.Price;
            if (ps != null) total += ps.Price;
            if (pcCase != null) total += pcCase.Price;

            return total;
        }

        private bool BuildExists(int id)
        {
            return _context.Builds.Any(e => e.Id == id);
        }
    }
}