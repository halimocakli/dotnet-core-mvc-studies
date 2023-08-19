using Microsoft.AspNetCore.Mvc;
using Repository_Metotlarının_Oluşturulması.Context;
using Repository_Metotlarının_Oluşturulması.Enums;
using Repository_Metotlarının_Oluşturulması.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository_Metotlarının_Oluşturulması.Controllers
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
