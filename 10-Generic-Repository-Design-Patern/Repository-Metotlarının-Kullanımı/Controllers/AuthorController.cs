using Microsoft.AspNetCore.Mvc;
using Repository_Metotlarının_Kullanımı.Context;
using Repository_Metotlarının_Kullanımı.Models;
using Repository_Metotlarının_Kullanımı.RepositoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository_Metotlarının_Kullanımı.Controllers
{
    public class AuthorController : Controller
    {
        IRepository<Author> _repositoryAuthor;
        public AuthorController(MyDbContext db, IRepository<Author> repositoryAuthor)
        {
            _repositoryAuthor = repositoryAuthor;
        }
        public IActionResult AuthorList()
        {
            List<Author> authors = _repositoryAuthor.GetAll();

            return View(authors);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Author author)
        {
            _repositoryAuthor.Add(author);

            return RedirectToAction("AuthorList");
        }
        public IActionResult Edit(int id)
        {
            Author author = _repositoryAuthor.GetById(id);

            return View(author);
        }

        [HttpPost]
        public IActionResult Edit(Author author)
        {
            _repositoryAuthor.Update(author);

            return RedirectToAction("AuthorList");
        }

        // Soft Delete
        // Verinin Status değeri silindi olarak etiketlenir ve veri database üzerinde kalmaya devam eder.
        public IActionResult Delete(int id)
        {
            _repositoryAuthor.Delete(id);

            return RedirectToAction("AuthorList");
        }
    }
}
