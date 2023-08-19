﻿using Login_İşlemleri.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Login_İşlemleri.RepositoryPattern.Interfaces;
using Login_İşlemleri.Dto;
using Login_İşlemleri.Models;
using Login_İşlemleri.Context;

namespace Login_İşlemleri.Areas.Management.Controllers
{
    [Area("Management")]
    public class BookController : Controller
    {
        MyDbContext _db;
        IBookRepository _repositoryBook;
        IAuthorRepository _repositoryAuthor;
        IBookTypeRepository _repositoryBookType;
        public BookController(MyDbContext db, IBookRepository repositoryBook, IAuthorRepository repositoryAuthor, IBookTypeRepository repositoryBookType)
        {
            _db = db;
            _repositoryBook = repositoryBook;
            _repositoryAuthor = repositoryAuthor;
            _repositoryBookType = repositoryBookType;
        }
        public IActionResult BookList()
        {
            // Join Yapısı (Include)

            List<BookDto> books = _repositoryBook.GetBookDto();

            return View(books);
        }
        public IActionResult Create()
        {
            List<AuthorDto> authors = _repositoryAuthor.SelectAuthorDto();
            List<BookTypeDto> bookTypes = _repositoryBookType.SelectBookTypeDto();

            return View((new Book(), authors, bookTypes));
        }

        [HttpPost]
        public IActionResult Create([Bind(Prefix = "Item1")] Book book)
        {
            _repositoryBook.Add(book);

            return RedirectToAction("BookList", "Book", new { area = "Management" });
        }
        public IActionResult Edit(int id)
        {

            Book book = _repositoryBook.GetById(id);
            List<AuthorDto> authors = _repositoryAuthor.SelectAuthorDto();
            List<BookTypeDto> bookTypes = _repositoryBookType.SelectBookTypeDto();

            return View((book, authors, bookTypes));
        }

        [HttpPost]
        public IActionResult Edit([Bind(Prefix = "Item1")] Book book)
        {
            if (book != null)
            {
                _repositoryBook.Update(book);
            }

            return RedirectToAction("BookList", "Book", new { area = "Management" });
        }

        // Soft Delete
        // Verinin Status değeri silindi olarak etiketlenir ve veri database üzerinde kalmaya devam eder.
        public IActionResult Delete(int id)
        {
            _repositoryBook.Delete(id);

            return RedirectToAction("BookList", "Book", new { area = "Management" });
        }
    }
}
