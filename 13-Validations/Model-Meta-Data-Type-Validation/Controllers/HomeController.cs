using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Model_Meta_Data_Type_Validation.Controllers
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
