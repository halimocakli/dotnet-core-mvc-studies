using Microsoft.AspNetCore.Mvc;

namespace Directory.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Directory()
        {
            return View();
        }
    }
}
