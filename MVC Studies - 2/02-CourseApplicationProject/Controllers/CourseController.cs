using _02_CourseApplicationProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace _02_CourseApplicationProject.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            var model = Repository.Applications;
            return View(model);
        }

        [HttpGet]
        public IActionResult Application()
        {
            return View();
        }

        // POST metodunun kullanımı sayesinde, Cadidate modeli, form üzerindeki veriler ile dolduruldu.
        // Bu işleme "MODEL BINDING" denir.
        // ValidateAntiForgeryToken data anotasyonu ile kötü niyetli girdilerin önüne geçiliyor. (Best Practise)
        // FromForm data anotasyonu ile verinin hangi yapıdan geldiğini spesifik hale getiriyoruz. (Best Practise)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Application([FromForm] Candidate candidateModel)
        {
            // Eğer herhangi bir öğrenci, aynı email ile birden fazla kez kayıt yapıyor ise ModelState'i valid olmaktan çıkarıyoruz.
            if(Repository.Applications.Any(a => a.Email.Equals(candidateModel.Email)))
            {
                ModelState.AddModelError("", "There is already an application for the same candidate!");
            }

            // Başvuru formundaki bütün gerekli alanların doldurulup doldurulmadığını kontrol ediyoruz.
            if (ModelState.IsValid)
            {
                Repository.Add(candidateModel);
                return View("Feedback", candidateModel);   // Home'a gider.
            }

            return View();
        }
    }
}