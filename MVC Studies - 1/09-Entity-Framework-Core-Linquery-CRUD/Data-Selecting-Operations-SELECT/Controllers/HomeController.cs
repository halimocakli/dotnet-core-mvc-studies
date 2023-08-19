using Microsoft.AspNetCore.Mvc;

namespace Data_Selecting_Operations_SELECT.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
