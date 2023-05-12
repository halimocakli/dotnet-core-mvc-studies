using GettingDataViaForms.Models;
using Microsoft.AspNetCore.Mvc;

namespace GettingDataViaForms.Controllers
{
    public class UserController : Controller
    {
        public IActionResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddUser(User user)
        {
            return View();
        }
    }
}
