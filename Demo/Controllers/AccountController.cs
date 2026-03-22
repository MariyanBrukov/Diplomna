using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Demo.Models;
using Demo.Models.ViewModels;

namespace Demo.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: /Account/Register
        [HttpGet]
        public IActionResult Register()
        {
            if (HttpContext.Session.GetInt32("UserId") != null)
                return RedirectToAction("Index", "Home");

            return View(new RegisterViewModel());
        }

        // POST: /Account/Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var emailExists = _context.Users.Any(u => u.Email == model.Email);
            if (emailExists)
            {
                ModelState.AddModelError(nameof(model.Email), "Email already exists.");
                return View(model);
            }

            var usernameExists = _context.Users.Any(u => u.Username == model.Username);
            if (usernameExists)
            {
                ModelState.AddModelError(nameof(model.Username), "Username already exists.");
                return View(model);
            }

            var user = new User
            {
                Username = model.Username,
                Email = model.Email,
                Password = model.Password,
                IsAdmin = false
            };

            _context.Users.Add(user);
            _context.SaveChanges();

            SignInUser(user);

            return RedirectToAction("Index", "Home");
        }

        // GET: /Account/Login
        [HttpGet]
        public IActionResult Login()
        {
            if (HttpContext.Session.GetInt32("UserId") != null)
                return RedirectToAction("Index", "Home");

            return View(new LoginViewModel());
        }

        // POST: /Account/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var user = _context.Users
                .FirstOrDefault(u => u.Email == model.Email && u.Password == model.Password);

            if (user == null)
            {
                ModelState.AddModelError("", "Invalid email or password.");
                return View(model);
            }

            SignInUser(user);

            return RedirectToAction("Index", "Home");
        }

        // POST: /Account/AdminLogin
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AdminLogin(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData["AdminLoginError"] = "Invalid admin login.";
                return RedirectToAction("Index", "Home");
            }

            var admin = _context.Users
                .FirstOrDefault(u =>
                    u.Email == model.Email &&
                    u.Password == model.Password &&
                    u.IsAdmin);

            if (admin == null)
            {
                TempData["AdminLoginError"] = "Invalid admin credentials.";
                return RedirectToAction("Index", "Home");
            }

            SignInUser(admin);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        private void SignInUser(User user)
        {
            HttpContext.Session.SetInt32("UserId", user.Id);
            HttpContext.Session.SetString("Username", user.Username);
            HttpContext.Session.SetString("IsAdmin", user.IsAdmin.ToString());
        }
    }
}