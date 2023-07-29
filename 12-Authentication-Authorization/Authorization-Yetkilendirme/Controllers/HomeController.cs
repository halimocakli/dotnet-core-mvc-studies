using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Authorization_Yetkilendirme.Controllers
{
    public class HomeController : Controller
    {
        [Authorize(Policy = "UserPolicy")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
