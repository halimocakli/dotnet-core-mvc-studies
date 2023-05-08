using GettingDataViaForms_ShowModelDataOnForm.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GettingDataViaForms_ShowModelDataOnForm.Controllers
{
    public class TeacherController : Controller
    {
        List<Branch> branches = new List<Branch>()
        {
            new Branch()
            {
                ID = 1,
                BranchName = "Matematik"
            },
            new Branch()
            {
                ID = 2,
                BranchName = "İngilizce"
            },
            new Branch()
            {
                ID = 3,
                BranchName = "Biyoloji"
            },
            new Branch()
            {
                ID = 4,
                BranchName = "Fizik"
            },
            new Branch()
            {
                ID = 5,
                BranchName = "Kimya"
            }
        };

        public IActionResult AddTeacher()
        {
            ViewBag.Branches = branches;

            // Model verisi oluşturup View katmanına gönderelim ve Form içerisinde veriler görüntülensin.
            Teacher teacher = new Teacher();
            teacher.FirstName = "Halim Can";
            teacher.LastName = "Ocaklı";
            teacher.BranchID = "3";

            return View(teacher);
        }

        [HttpPost]
        public IActionResult AddTeacher(Teacher teacher)
        {
            ViewBag.Branches = branches;
            return View();
        }

        public IActionResult AddTeacherUsingTuple()
        {
            // Model verisi oluşturup View katmanına gönderelim ve Form içerisinde veriler görüntülensin.
            Teacher teacher = new Teacher();
            teacher.FirstName = "Halim Can";
            teacher.LastName = "Ocaklı";
            teacher.BranchID = "3";

            (List<Branch>, Teacher, Student) tupleObject = (branches, teacher, new Student());
            return View(tupleObject);
        }

        [HttpPost]
        public IActionResult AddTeacherUsingTuple([Bind(Prefix = "Item2")] Teacher teacher, [Bind(Prefix = "Item3")] Student student)
        {
            return RedirectToAction("AddTeacherUsingTuple");
        }
    }
}
