using Microsoft.AspNetCore.Mvc;

namespace Data_Listing_Operations_READ.Controllers
{
    public class BookController : Controller
    {
        public IActionResult BookList()
        {
            return View();
        }
    }
}
