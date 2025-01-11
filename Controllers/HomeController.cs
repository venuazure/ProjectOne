using Microsoft.AspNetCore.Mvc;
using mvc.Data;
using mvc.Models;

namespace mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserDbContext _context;

        public HomeController(UserDbContext context)
        {
            _context = context;
            
        }

        public IActionResult UserForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveUser(User user)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return RedirectToAction("Confirmation");
            }

            return View("UserForm", user);
        }

        public IActionResult Confirmation()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
