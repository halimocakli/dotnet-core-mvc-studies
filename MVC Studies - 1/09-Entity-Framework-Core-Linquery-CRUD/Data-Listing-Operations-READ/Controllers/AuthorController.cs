using Data_Listing_Operations_READ.Context;
using Data_Listing_Operations_READ.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Data_Listing_Operations_READ.Controllers
{
    public class AuthorController : Controller
    {
        MyDbContext _db;
        public AuthorController(MyDbContext db)
        {
            _db = db;
        }
        public IActionResult AuthorList()
        {
            List<Author> authors = _db.Authors.ToList();
            return View(authors);
        }
    }
}
