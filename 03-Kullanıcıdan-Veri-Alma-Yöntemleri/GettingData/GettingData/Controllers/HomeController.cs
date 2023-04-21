using Microsoft.AspNetCore.Mvc;

namespace GettingData.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
