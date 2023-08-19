using Microsoft.AspNetCore.Mvc;
using Repository_Metotlarının_Kullanımı.Context;
using Repository_Metotlarının_Kullanımı.Enums;
using Repository_Metotlarının_Kullanımı.Models;
using Repository_Metotlarının_Kullanımı.RepositoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository_Metotlarının_Kullanımı.Controllers
{
    public class BookTypeController : Controller
    {
        IRepository<BookType> _repositoryBookType;
        public BookTypeController(IRepository<BookType> repositoryBookType)
        {
            _repositoryBookType = repositoryBookType;
        }
        public IActionResult BookTypeList()
        {
            List<BookType> bookTypes = _repositoryBookType.GetAll();

            return View(bookTypes);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(BookType bookType)
        {
            _repositoryBookType.Add(bookType);

            return RedirectToAction("BookTypeList");
        }

        public IActionResult Edit(int id)
        {
            BookType bookType = _repositoryBookType.GetById(id);

            return View(bookType);
        }

        [HttpPost]
        public IActionResult Edit(BookType bookType)
        {
            _repositoryBookType.Update(bookType);

            return RedirectToAction("BookTypeList");
        }
        // Hard Delete
        public IActionResult HardDelete(int id)
        {
            _repositoryBookType.SpecialDelete(id);

            return RedirectToAction("BookTypeList");
        }
    }
}
