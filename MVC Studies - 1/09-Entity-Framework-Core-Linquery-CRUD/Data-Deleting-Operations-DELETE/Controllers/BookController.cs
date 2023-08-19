using Data_Deleting_Operations_DELETE.Context;
using Data_Deleting_Operations_DELETE.Models;
using Microsoft.AspNetCore.Mvc;

namespace Data_Deleting_Operations_DELETE.Controllers
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
