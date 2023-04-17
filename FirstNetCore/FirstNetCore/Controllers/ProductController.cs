using Microsoft.AspNetCore.Mvc;

namespace FirstNetCore.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
