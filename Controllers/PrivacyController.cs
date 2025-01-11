using Microsoft.AspNetCore.Mvc;

namespace mvc.Controllers
{
    public class PrivacyController : Controller
    {
        public IActionResult Privacy()
        {
            return View("~/Views/Home/Privacy.cshtml");
        }
    }
}
