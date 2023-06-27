using Data_Updating_Operations_UPDATE.Context;
using Data_Updating_Operations_UPDATE.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Data_Updating_Operations_UPDATE.Controllers
{
    public class BookTypeController : Controller
    {
        MyDbContext _db;
        public BookTypeController(MyDbContext db)
        {
            _db = db;
        }
        public IActionResult BookTypeList()
        {
            List<BookType> bookTypes = _db.BookTypes.ToList();
            return View(bookTypes);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(BookType bookType)
        {
            _db.BookTypes.Add(bookType);
            _db.SaveChanges();
            return RedirectToAction("BookTypeList");
        }

        public IActionResult Edit(int id)
        {
            BookType bookType = _db.BookTypes.Find(id);
            return View(bookType);
        }

        [HttpPost]
        public IActionResult Edit(BookType bookType)
        {
            bookType.Status = Enums.DataStatus.Updated;
            bookType.UpdatedDateTime = DateTime.Now;

            _db.BookTypes.Update(bookType);
            _db.SaveChanges();

            return RedirectToAction("BookTypeList");
        }
    }
}
