using Microsoft.AspNetCore.Mvc;

namespace Repository_Metotlarının_Oluşturulması.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
