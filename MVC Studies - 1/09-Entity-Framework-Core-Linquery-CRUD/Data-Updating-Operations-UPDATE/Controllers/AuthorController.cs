using Data_Updating_Operations_UPDATE.Context;
using Data_Updating_Operations_UPDATE.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Data_Updating_Operations_UPDATE.Controllers
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
    }
}
