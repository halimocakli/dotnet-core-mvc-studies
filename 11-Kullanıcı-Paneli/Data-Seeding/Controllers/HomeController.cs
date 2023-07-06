using Microsoft.AspNetCore.Mvc;

namespace Data_Seeding.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
