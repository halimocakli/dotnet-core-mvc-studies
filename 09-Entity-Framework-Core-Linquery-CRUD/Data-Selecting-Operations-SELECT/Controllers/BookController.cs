using Data_Selecting_Operations_SELECT.Context;
using Data_Selecting_Operations_SELECT.Dto;
using Data_Selecting_Operations_SELECT.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Data_Selecting_Operations_SELECT.Controllers
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
            return View();
        }
        public IActionResult Create()
        {
            List<AuthorDto> authors = _db.Authors
                .Where(x => x.Status != Enums.DataStatus.Deleted)
                .Select(x => new AuthorDto()
                {
                    Id = x.Id,
                    FirstName = x.FirstName,
                    LastName = x.LastName
                }).ToList();

            List<BookTypeDto> bookTypes = _db.BookTypes
               .Where(x => x.Status != Enums.DataStatus.Deleted)
               .Select(x => new BookTypeDto()
               {
                   Id = x.Id,
                   TypeName = x.TypeName,
               }).ToList();

            return View((new Book(), authors, bookTypes));
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            _db.Add(book);
            _db.SaveChanges();
            return RedirectToAction("BookList");
        }
    }
}
