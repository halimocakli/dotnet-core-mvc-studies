using Microsoft.AspNetCore.Mvc;

namespace Repository_Metotlarının_Kullanımı.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
