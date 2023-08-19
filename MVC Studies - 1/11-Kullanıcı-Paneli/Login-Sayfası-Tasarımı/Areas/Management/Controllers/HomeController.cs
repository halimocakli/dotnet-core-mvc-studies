using Microsoft.AspNetCore.Mvc;

namespace Login_Sayfası_Tasarımı.Areas.Management.Controllers
{
    [Area("Management")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
