using Data_Select_And_Add_Book.Context;
using Data_Select_And_Add_Book.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Data_Select_And_Add_Book.Controllers
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
            // List<Author> authors = _db.Authors.ToList();
            List<Author> authors = _db.Authors.Where(a => a.Status != Enums.DataStatus.Deleted).ToList();
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
        public IActionResult Edit(int id)
        {
            Author author = _db.Authors.Find(id);
            return View(author);
        }

        [HttpPost]
        public IActionResult Edit(Author author)
        {
            author.Status = Enums.DataStatus.Updated;
            author.UpdatedDateTime = DateTime.Now;

            _db.Authors.Update(author);
            _db.SaveChanges();

            return RedirectToAction("AuthorList");
        }
        // Soft Delete
        // Verinin Status değeri silindi olarak etiketlenir ve veri database üzerinde kalmaya devam eder.
        public IActionResult Delete(int id)
        {
            Author author = _db.Authors.Find(id);

            author.Status = Enums.DataStatus.Deleted;
            author.UpdatedDateTime = DateTime.Now;

            _db.Authors.Update(author);
            _db.SaveChanges();

            return RedirectToAction("AuthorList");
        }
    }
}
