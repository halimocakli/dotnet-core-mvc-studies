using Microsoft.AspNetCore.Mvc;

namespace FirstDotnetCoreImplementation.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
