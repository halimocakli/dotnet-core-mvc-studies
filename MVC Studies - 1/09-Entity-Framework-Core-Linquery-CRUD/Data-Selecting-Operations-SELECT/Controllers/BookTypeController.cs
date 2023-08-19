using Data_Selecting_Operations_SELECT.Context;
using Data_Selecting_Operations_SELECT.Enums;
using Data_Selecting_Operations_SELECT.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Data_Selecting_Operations_SELECT.Controllers
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
            bookType.Status = DataStatus.Updated;
            bookType.UpdatedDateTime = DateTime.Now;

            _db.BookTypes.Update(bookType);
            _db.SaveChanges();

            return RedirectToAction("BookTypeList");
        }
        // Hard Delete
        public IActionResult HardDelete(int id)
        {
            BookType bookType = _db.BookTypes.Find(id);

            _db.BookTypes.Remove(bookType);
            _db.SaveChanges();

            return RedirectToAction("BookTypeList");
        }
    }
}
