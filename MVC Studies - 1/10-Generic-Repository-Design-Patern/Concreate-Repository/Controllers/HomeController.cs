using Microsoft.AspNetCore.Mvc;

namespace Concreate_Repository.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
