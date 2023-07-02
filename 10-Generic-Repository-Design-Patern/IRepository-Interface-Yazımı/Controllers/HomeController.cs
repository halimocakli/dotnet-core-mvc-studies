using Microsoft.AspNetCore.Mvc;

namespace IRepository_Interface_Yazımı.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
