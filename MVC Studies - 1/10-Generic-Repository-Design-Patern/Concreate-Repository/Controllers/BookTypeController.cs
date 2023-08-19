using Concreate_Repository.Models;
using Concreate_Repository.RepositoryPattern.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Concreate_Repository.Context;
using Concreate_Repository.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using Concreate_Repository.Dto;

namespace Concreate_Repository.Controllers
{
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
