using Microsoft.AspNetCore.Mvc;
using Login_Sayfası_Tasarımı.Context;
using Login_Sayfası_Tasarımı.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using Login_Sayfası_Tasarımı.Dto;
using Login_Sayfası_Tasarımı.RepositoryPattern.Interfaces;
using Login_Sayfası_Tasarımı.Models;

namespace Login_Sayfası_Tasarımı.Areas.Management.Controllers
{
    [Area("Management")]
    public class BookTypeController : Controller
    {
        IBookTypeRepository _repositoryBookType;
        public BookTypeController(IBookTypeRepository repositoryBookType)
        {
            _repositoryBookType = repositoryBookType;
        }
        public IActionResult BookTypeList()
        {
            List<BookTypeDto> bookTypes = _repositoryBookType.SelectBookTypeDto();

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

            return RedirectToAction("BookTypeList", "BookType", new { area = "Management" });
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

            return RedirectToAction("BookTypeList", "BookType", new { area = "Management" });
        }
        // Hard Delete
        public IActionResult HardDelete(int id)
        {
            _repositoryBookType.SpecialDelete(id);

            return RedirectToAction("BookTypeList", "BookType", new { area = "Management" });
        }
    }
}
