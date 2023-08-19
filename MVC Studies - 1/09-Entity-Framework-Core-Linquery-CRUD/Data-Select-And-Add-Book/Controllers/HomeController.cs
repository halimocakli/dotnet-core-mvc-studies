using Microsoft.AspNetCore.Mvc;

namespace Data_Select_And_Add_Book.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
