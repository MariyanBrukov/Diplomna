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
            var applicationDbContext = _context.Builds.Include(b => b.CPU).Include(b => b.Case).Include(b => b.GPU).Include(b => b.Motherboard).Include(b => b.PowerSupply).Include(b => b.RAM).Include(b => b.Storage);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Builds/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var build = await _context.Builds
                .Include(b => b.CPU)
                .Include(b => b.Case)
                .Include(b => b.GPU)
                .Include(b => b.Motherboard)
                .Include(b => b.PowerSupply)
                .Include(b => b.RAM)
                .Include(b => b.Storage)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (build == null)
            {
                return NotFound();
            }

            return View(build);
        }

        // GET: Builds/Create
        public IActionResult Create()
        {
            ViewData["CPUId"] = new SelectList(_context.CPUs, "Id", "Name");
            ViewData["CaseId"] = new SelectList(_context.Cases, "Id", "Name");
            ViewData["GPUId"] = new SelectList(_context.GPUs, "Id", "Name");
            ViewData["MotherboardId"] = new SelectList(_context.Motherboards, "Id", "Name");
            ViewData["PowerSupplyId"] = new SelectList(_context.PowerSupplies, "Id", "Name");
            ViewData["RAMId"] = new SelectList(_context.RAMs, "Id", "Name");
            ViewData["StorageId"] = new SelectList(_context.Storages, "Id", "Name");
            return View();
        }

        // POST: Builds/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BuildName,CPUId,GPUId,MotherboardId,RAMId,StorageId,PowerSupplyId,CaseId,TotalPrice")] Build build)
        {
            if (ModelState.IsValid)
            {
                _context.Add(build);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CPUId"] = new SelectList(_context.CPUs, "Id", "Name", build.CPUId);
            ViewData["CaseId"] = new SelectList(_context.Cases, "Id", "Name", build.CaseId);
            ViewData["GPUId"] = new SelectList(_context.GPUs, "Id", "Name", build.GPUId);
            ViewData["MotherboardId"] = new SelectList(_context.Motherboards, "Id", "Name", build.MotherboardId);
            ViewData["PowerSupplyId"] = new SelectList(_context.PowerSupplies, "Id", "Name", build.PowerSupplyId);
            ViewData["RAMId"] = new SelectList(_context.RAMs, "Id", "Name", build.RAMId);
            ViewData["StorageId"] = new SelectList(_context.Storages, "Id", "Name", build.StorageId);
            return View(build);
        }

        // GET: Builds/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var build = await _context.Builds.FindAsync(id);
            if (build == null)
            {
                return NotFound();
            }
            ViewData["CPUId"] = new SelectList(_context.CPUs, "Id", "Name", build.CPUId);
            ViewData["CaseId"] = new SelectList(_context.Cases, "Id", "Name", build.CaseId);
            ViewData["GPUId"] = new SelectList(_context.GPUs, "Id", "Name", build.GPUId);
            ViewData["MotherboardId"] = new SelectList(_context.Motherboards, "Id", "Name", build.MotherboardId);
            ViewData["PowerSupplyId"] = new SelectList(_context.PowerSupplies, "Id", "Name", build.PowerSupplyId);
            ViewData["RAMId"] = new SelectList(_context.RAMs, "Id", "Name", build.RAMId);
            ViewData["StorageId"] = new SelectList(_context.Storages, "Id", "Name", build.StorageId);
            return View(build);
        }

        // POST: Builds/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,BuildName,CPUId,GPUId,MotherboardId,RAMId,StorageId,PowerSupplyId,CaseId,TotalPrice")] Build build)
        {
            if (id != build.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(build);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BuildExists(build.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CPUId"] = new SelectList(_context.CPUs, "Id", "Name", build.CPUId);
            ViewData["CaseId"] = new SelectList(_context.Cases, "Id", "Name", build.CaseId);
            ViewData["GPUId"] = new SelectList(_context.GPUs, "Id", "Name", build.GPUId);
            ViewData["MotherboardId"] = new SelectList(_context.Motherboards, "Id", "Name", build.MotherboardId);
            ViewData["PowerSupplyId"] = new SelectList(_context.PowerSupplies, "Id", "Name", build.PowerSupplyId);
            ViewData["RAMId"] = new SelectList(_context.RAMs, "Id", "Name", build.RAMId);
            ViewData["StorageId"] = new SelectList(_context.Storages, "Id", "Name", build.StorageId);
            return View(build);
        }

        // GET: Builds/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var build = await _context.Builds
                .Include(b => b.CPU)
                .Include(b => b.Case)
                .Include(b => b.GPU)
                .Include(b => b.Motherboard)
                .Include(b => b.PowerSupply)
                .Include(b => b.RAM)
                .Include(b => b.Storage)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (build == null)
            {
                return NotFound();
            }

            return View(build);
        }

        // POST: Builds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var build = await _context.Builds.FindAsync(id);
            if (build != null)
            {
                _context.Builds.Remove(build);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BuildExists(int id)
        {
            return _context.Builds.Any(e => e.Id == id);
        }
    }
}
