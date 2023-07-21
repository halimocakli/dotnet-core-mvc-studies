using Microsoft.AspNetCore.Mvc;

namespace Authentication_Kimlik_Doğrulama.Areas.Management.Controllers
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
