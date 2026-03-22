using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Demo.Models;

namespace Demo.Controllers
{
    public class ContactsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContactsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // ADMIN ONLY: ticket list
        public async Task<IActionResult> Index()
        {
            if (!IsAdmin())
                return RedirectToAction("Create");

            var tickets = await _context.Contacts
                .OrderByDescending(c => c.CreatedAt)
                .ToListAsync();

            return View(tickets);
        }

        // ADMIN ONLY: ticket details + reply area
        public async Task<IActionResult> Details(int? id)
        {
            if (!IsAdmin())
                return RedirectToAction("Create");

            if (id == null)
                return NotFound();

            var contact = await _context.Contacts
                .FirstOrDefaultAsync(m => m.Id == id);

            if (contact == null)
                return NotFound();

            return View(contact);
        }

        // USER: create ticket page
        public IActionResult Create()
        {
            return View();
        }

        // USER: submit ticket
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Email,Subject,Message")] Contact contact)
        {
            if (!ModelState.IsValid)
                return View(contact);

            contact.CreatedAt = DateTime.Now;
            contact.IsAnswered = false;
            contact.AdminReply = null;
            contact.ReplyDate = null;

            _context.Add(contact);
            await _context.SaveChangesAsync();

            TempData["SuccessMessage"] = "Your ticket has been sent successfully.";
            return RedirectToAction(nameof(Create));
        }

        // ADMIN ONLY: reply to ticket
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Reply(int id, string adminReply)
        {
            if (!IsAdmin())
                return RedirectToAction("Login", "Account");

            var contact = await _context.Contacts.FindAsync(id);
            if (contact == null)
                return NotFound();

            if (string.IsNullOrWhiteSpace(adminReply))
            {
                TempData["ReplyError"] = "Reply cannot be empty.";
                return RedirectToAction(nameof(Details), new { id });
            }

            contact.AdminReply = adminReply;
            contact.IsAnswered = true;
            contact.ReplyDate = DateTime.Now;

            _context.Update(contact);
            await _context.SaveChangesAsync();

            TempData["ReplySuccess"] = "Reply saved successfully.";
            return RedirectToAction(nameof(Details), new { id });
        }

        // ADMIN ONLY: optional edit ticket text itself
        public async Task<IActionResult> Edit(int? id)
        {
            if (!IsAdmin())
                return RedirectToAction("Login", "Account");

            if (id == null)
                return NotFound();

            var contact = await _context.Contacts.FindAsync(id);
            if (contact == null)
                return NotFound();

            return View(contact);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Email,Subject,Message,AdminReply,ReplyDate,IsAnswered,CreatedAt")] Contact contact)
        {
            if (!IsAdmin())
                return RedirectToAction("Login", "Account");

            if (id != contact.Id)
                return NotFound();

            if (!ModelState.IsValid)
                return View(contact);

            try
            {
                _context.Update(contact);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContactExists(contact.Id))
                    return NotFound();
                else
                    throw;
            }

            return RedirectToAction(nameof(Index));
        }

        // ADMIN ONLY: delete
        public async Task<IActionResult> Delete(int? id)
        {
            if (!IsAdmin())
                return RedirectToAction("Login", "Account");

            if (id == null)
                return NotFound();

            var contact = await _context.Contacts
                .FirstOrDefaultAsync(m => m.Id == id);

            if (contact == null)
                return NotFound();

            return View(contact);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (!IsAdmin())
                return RedirectToAction("Login", "Account");

            var contact = await _context.Contacts.FindAsync(id);
            if (contact != null)
                _context.Contacts.Remove(contact);

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContactExists(int id)
        {
            return _context.Contacts.Any(e => e.Id == id);
        }

        private bool IsAdmin()
        {
            return HttpContext.Session.GetString("IsAdmin") == "True";
        }
    }
}