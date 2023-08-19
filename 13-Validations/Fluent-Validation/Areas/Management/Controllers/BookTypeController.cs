using Microsoft.AspNetCore.Mvc;
using Fluent_Validation.Context;
using Fluent_Validation.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Fluent_Validation.RepositoryPattern.Interfaces;
using Fluent_Validation.Models;
using Fluent_Validation.Dto;

namespace Fluent_Validation.Areas.Management.Controllers
{
    [Area("Management")]
    [Authorize(Policy = "AdminPolicy")]
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
            if (!ModelState.IsValid)
            {
                return View(bookType);
            }

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
            if (!ModelState.IsValid)
            {
                return View(bookType);
            }

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
