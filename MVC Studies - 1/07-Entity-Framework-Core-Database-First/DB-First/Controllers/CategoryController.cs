using DB_First.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace DB_First.Controllers
{
    public class CategoryController : Controller
    {
        NORTHWINDContext _db;
        public CategoryController(NORTHWINDContext db)
        {
            _db = db;
        }
        public IActionResult CategoryList()
        {
            List<Category> categorylist = _db.Categories.ToList();
            return View(categorylist);
        }
    }
}
