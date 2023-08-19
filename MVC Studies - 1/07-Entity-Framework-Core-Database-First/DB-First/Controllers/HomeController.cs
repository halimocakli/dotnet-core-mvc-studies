using Microsoft.AspNetCore.Mvc;

namespace DB_First.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
