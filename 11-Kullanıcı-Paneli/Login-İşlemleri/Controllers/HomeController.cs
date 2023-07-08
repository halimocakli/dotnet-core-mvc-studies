using Microsoft.AspNetCore.Mvc;

namespace Login_İşlemleri.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
