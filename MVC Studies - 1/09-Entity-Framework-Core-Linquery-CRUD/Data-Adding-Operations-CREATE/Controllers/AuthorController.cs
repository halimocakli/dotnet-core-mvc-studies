using Data_Adding_Operations_CREATE.Context;
using Data_Adding_Operations_CREATE.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Data_Adding_Operations_CREATE.Controllers
{
    public class AuthorController : Controller
    {
        MyDbContext _db;
        public AuthorController(MyDbContext db)
        {
            _db = db;
        }
        public IActionResult AuthorList()
        {
            List<Author> authors = _db.Authors.ToList();
            return View(authors);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Author author)
        {
            _db.Authors.Add(author);
            _db.SaveChanges();
            return RedirectToAction("AuthorList");
        }
    }
}
