using Microsoft.AspNetCore.Mvc;

namespace FirstDotnetCoreImplementations.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
