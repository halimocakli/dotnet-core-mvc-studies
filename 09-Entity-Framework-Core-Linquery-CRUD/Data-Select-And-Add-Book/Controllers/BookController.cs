﻿using Data_Select_And_Add_Book.Context;
using Data_Select_And_Add_Book.Dto;
using Data_Select_And_Add_Book.Enums;
using Data_Select_And_Add_Book.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Data_Select_And_Add_Book.Controllers
{
    public class BookController : Controller
    {
        MyDbContext _db;
        public BookController(MyDbContext db)
        {
            _db = db;
        }
        public IActionResult BookList()
        {
            // Join Yapısı (Include)

            List<BookDto> books = _db.Books
                .Where(b => b.Status != Enums.DataStatus.Deleted)
                .Include(x => x.Author)
                .Include(x => x.BookType)
                .Select(x => new BookDto()
                {
                    Id = x.Id,
                    BookTitle = x.Title,
                    AuthorFirstName = x.Author.FirstName,
                    AuthorLastName = x.Author.LastName,
                    BookTypeName = x.BookType.TypeName,
                    BookPageCount = x.PageCount
                })
                .ToList();

            return View(books);
        }
        public IActionResult Create()
        {
            List<AuthorDto> authors = _db.Authors
                .Where(x => x.Status != DataStatus.Deleted)
                .Select(x => new AuthorDto()
                {
                    Id = x.Id,
                    FirstName = x.FirstName,
                    LastName = x.LastName
                }).ToList();

            List<BookTypeDto> bookTypes = _db.BookTypes
               .Where(x => x.Status != DataStatus.Deleted)
               .Select(x => new BookTypeDto()
               {
                   Id = x.Id,
                   TypeName = x.TypeName,
               }).ToList();

            return View((new Book(), authors, bookTypes));
        }

        [HttpPost]
        public IActionResult Create([Bind(Prefix = "Item1")] Book book)
        {
            _db.Books.Add(book);
            _db.SaveChanges();

            return RedirectToAction("BookList");
        }
        public IActionResult Edit(int id)
        {
            Book book = _db.Books.Find(id);

            List<AuthorDto> authors = _db.Authors
                .Where(x => x.Status != DataStatus.Deleted)
                .Select(x => new AuthorDto()
                {
                    Id = x.Id,
                    FirstName = x.FirstName,
                    LastName = x.LastName
                }).ToList();

            List<BookTypeDto> bookTypes = _db.BookTypes
               .Where(x => x.Status != DataStatus.Deleted)
               .Select(x => new BookTypeDto()
               {
                   Id = x.Id,
                   TypeName = x.TypeName,
               }).ToList();

            return View((book, authors, bookTypes));
        }

        [HttpPost]
        public IActionResult Edit([Bind(Prefix = "Item1")] Book book)
        {
            if (book != null)
            {
                book.Status = DataStatus.Updated;
                book.UpdatedDateTime = DateTime.Now;

                _db.Books.Update(book);
                _db.SaveChanges();
            }

            return RedirectToAction("BookList");
        }

        // Soft Delete
        // Verinin Status değeri silindi olarak etiketlenir ve veri database üzerinde kalmaya devam eder.
        public IActionResult Delete(int id)
        {
            Book book = _db.Books.Find(id);

            book.Status = Enums.DataStatus.Deleted;
            book.UpdatedDateTime = DateTime.Now;

            _db.Books.Update(book);
            _db.SaveChanges();

            return RedirectToAction("BookList");
        }
    }
}
