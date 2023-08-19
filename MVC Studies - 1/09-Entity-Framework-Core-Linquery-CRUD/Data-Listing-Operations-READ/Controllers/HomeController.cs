using Microsoft.AspNetCore.Mvc;

namespace Data_Listing_Operations_READ.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
