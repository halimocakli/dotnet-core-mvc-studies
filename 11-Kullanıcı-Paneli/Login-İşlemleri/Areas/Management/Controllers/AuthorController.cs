using Login_İşlemleri.Models;
using Login_İşlemleri.RepositoryPattern.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Login_İşlemleri.Areas.Management.Controllers
{
    [Area("Management")]
    public class AuthorController : Controller
    {
        IAuthorRepository _repositoryAuthor;
        public AuthorController(IAuthorRepository repositoryAuthor)
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

            return RedirectToAction("AuthorList", "Author", new { area = "Management" });
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

            return RedirectToAction("AuthorList", "Author", new { area = "Management" });
        }

        // Soft Delete
        // Verinin Status değeri silindi olarak etiketlenir ve veri database üzerinde kalmaya devam eder.
        public IActionResult Delete(int id)
        {
            _repositoryAuthor.Delete(id);

            return RedirectToAction("AuthorList", "Author", new { area = "Management" });
        }
    }
}
