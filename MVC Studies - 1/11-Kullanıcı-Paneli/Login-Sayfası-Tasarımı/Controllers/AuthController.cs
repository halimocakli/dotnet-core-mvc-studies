using Login_Sayfası_Tasarımı.Models;
using Microsoft.AspNetCore.Mvc;

namespace Login_Sayfası_Tasarımı.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(AppUser user)
        {
            return View();
        }
    }
}
