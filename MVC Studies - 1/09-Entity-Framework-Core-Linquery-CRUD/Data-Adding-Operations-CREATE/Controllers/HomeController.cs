using Microsoft.AspNetCore.Mvc;

namespace Data_Adding_Operations_CREATE.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
