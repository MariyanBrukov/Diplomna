using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        // GET: Builds
        public async Task<IActionResult> Index()
        {
            var builds = _context.Builds
                .Include(b => b.CPU)
                .Include(b => b.GPU)
                .Include(b => b.Motherboard)
                .Include(b => b.RAM)
                .Include(b => b.Storage)
                .Include(b => b.PowerSupply)
                .Include(b => b.Case);

            return View(await builds.ToListAsync());
        }

        // GET: Builds/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var build = await _context.Builds
                .Include(b => b.CPU)
                .Include(b => b.GPU)
                .Include(b => b.Motherboard)
                .Include(b => b.RAM)
                .Include(b => b.Storage)
                .Include(b => b.PowerSupply)
                .Include(b => b.Case)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (build == null)
                return NotFound();

            return View(build);
        }

        // GET: Builds/Create
        public IActionResult Create()
        {
            PopulateDropdowns();
            return View();
        }

        // POST: Builds/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BuildName,CPUId,GPUId,MotherboardId,RAMId,StorageId,PowerSupplyId,CaseId")] Build build)
        {
            if (ModelState.IsValid)
            {
                build.TotalPrice = await CalculateTotalPrice(build);
                _context.Add(build);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            PopulateDropdowns(build);
            return View(build);
        }

        // GET: Builds/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var build = await _context.Builds.FindAsync(id);
            if (build == null)
                return NotFound();

            PopulateDropdowns(build);
            return View(build);
        }

        // POST: Builds/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,BuildName,CPUId,GPUId,MotherboardId,RAMId,StorageId,PowerSupplyId,CaseId")] Build build)
        {
            if (id != build.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    build.TotalPrice = await CalculateTotalPrice(build);
                    _context.Update(build);
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

        // GET: Builds/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var build = await _context.Builds
                .Include(b => b.CPU)
                .Include(b => b.GPU)
                .Include(b => b.Motherboard)
                .Include(b => b.RAM)
                .Include(b => b.Storage)
                .Include(b => b.PowerSupply)
                .Include(b => b.Case)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (build == null)
                return NotFound();

            return View(build);
        }

        // POST: Builds/DeleteConfirmed/5
        [HttpPost, ActionName("DeleteConfirmed")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var build = await _context.Builds.FindAsync(id);
            if (build != null)
            {
                _context.Builds.Remove(build);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }

        // Utility: Populate dropdowns for Create/Edit
        private void PopulateDropdowns(Build? build = null)
        {
            ViewData["CPUId"] = new SelectList(_context.CPUs, "Id", "Name", build?.CPUId);
            ViewData["GPUId"] = new SelectList(_context.GPUs, "Id", "Name", build?.GPUId);
            ViewData["MotherboardId"] = new SelectList(_context.Motherboards, "Id", "Name", build?.MotherboardId);
            ViewData["RAMId"] = new SelectList(_context.RAMs, "Id", "Name", build?.RAMId);
            ViewData["StorageId"] = new SelectList(_context.Storages, "Id", "Name", build?.StorageId);
            ViewData["PowerSupplyId"] = new SelectList(_context.PowerSupplies, "Id", "Name", build?.PowerSupplyId);
            ViewData["CaseId"] = new SelectList(_context.Cases, "Id", "Name", build?.CaseId);
        }

        // Utility: Calculate total based on selected parts
        private async Task<decimal> CalculateTotalPrice(Build build)
        {
            decimal total = 0;

            var cpu = await _context.CPUs.FindAsync(build.CPUId);
            var gpu = await _context.GPUs.FindAsync(build.GPUId);
            var mb = await _context.Motherboards.FindAsync(build.MotherboardId);
            var ram = await _context.RAMs.FindAsync(build.RAMId);
            var storage = await _context.Storages.FindAsync(build.StorageId);
            var ps = await _context.PowerSupplies.FindAsync(build.PowerSupplyId);
            var pcCase = await _context.Cases.FindAsync(build.CaseId);

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
