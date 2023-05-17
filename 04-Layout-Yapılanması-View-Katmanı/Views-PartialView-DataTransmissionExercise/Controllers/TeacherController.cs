using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Views_PartialView_DataTransmissionExercise.Models;

namespace Views_PartialView_DataTransmissionExercise.Controllers
{
    public class TeacherController : Controller
    {
        List<Teacher> teachers = new List<Teacher>()
        {
            new Teacher()
            {
                ID = 1,
                FirstName = "Raziye",
                LastName = "Dogan",
                Gender = "Female"
            },
            new Teacher()
            {
                ID = 2,
                FirstName = "Halim Can",
                LastName = "Ocaklı",
                Gender = "Male"
            },
            new Teacher()
            {
                ID = 3,
                FirstName = "Oğuzhan",
                LastName = "Deniz",
                Gender = "Male"
            },
            new Teacher()
            {
                ID = 4,
                FirstName = "Berkin",
                LastName = "Topaloğlu",
                Gender = "Male"
            },
            new Teacher()
            {
                ID = 5,
                FirstName = "Yasin",
                LastName = "Mersin",
                Gender = "Male"
            },
            new Teacher()
            {
                ID = 6,
                FirstName = "İrem",
                LastName = "Alkaşi",
                Gender = "Female"
            }
        };

        public IActionResult GetTeacherList()
        {
            // Bir Action'dan herhangi bir View'a model gönderdiğimizde, eğer model gönderdiğimiz View'dan herhangi bir Partial View çağırılıyorsa,
            // o Partial View'a da bahsi geçen model gider. Aynı şekilde bir ViewBag'i View'a gönderirsek, o View'ın kullandığı bütün Partial View'lar,
            // gönderilen ViewBag'i kullanabilir.

            return View(teachers);
        }
        public IActionResult DeleteTeacher(int id)
        {
            Teacher teacher = teachers.Find(x => x.ID == id);
            return View(teacher);
        }
    }
}
