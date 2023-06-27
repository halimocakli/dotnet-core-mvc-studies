using Data_Updating_Operations_UPDATE.Context;
using Data_Updating_Operations_UPDATE.Models;
using Microsoft.AspNetCore.Mvc;

namespace Data_Updating_Operations_UPDATE.Controllers
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
