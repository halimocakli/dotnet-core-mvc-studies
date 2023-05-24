using Microsoft.AspNetCore.Mvc;

namespace LayoutUsage.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Page_1() 
        {
            return View();
        }
        public IActionResult Page_2()
        {
            return View();
        }
        public IActionResult Page_3()
        {
            return View();
        }
        public IActionResult LoginAsTeacher()
        {
            return View();
        }
        public IActionResult LoginAsStudent()
        {
            return View();
        }
        public IActionResult LoginAsParent()
        {
            return View();
        }
    }
}
