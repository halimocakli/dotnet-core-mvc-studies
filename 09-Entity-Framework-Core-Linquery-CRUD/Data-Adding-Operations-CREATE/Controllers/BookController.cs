using Data_Adding_Operations_CREATE.Context;
using Data_Adding_Operations_CREATE.Models;
using Microsoft.AspNetCore.Mvc;

namespace Data_Adding_Operations_CREATE.Controllers
{
    public class BookController : Controller
    {
        MyDbContext _db;
        public BookController(MyDbContext db)
        {
            _db = db;
        }
        public IActionResult BookList()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            _db.Add(book);
            _db.SaveChanges();
            return RedirectToAction("BookList");
        }
    }
}
