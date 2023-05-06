using GettingDataViaForms_Exercise_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.JSInterop;
using System.Collections.Generic;

namespace GettingDataViaForms_Exercise.Controllers
{
    public class StudentController : Controller
    {
        List<Student> students = new List<Student>()
        {
            new Student()
            {
                FirstName = "Raziye",
                LastName = "Dogan",
                StudentID = "1910206500"
            },
            new Student()
            {
                FirstName = "Halim Can",
                LastName = "Ocaklı",
                StudentID = "1910206501"
            },
            new Student()
            {
                FirstName = "Oğuzhan",
                LastName = "Deniz",
                StudentID = "1910206502"
            },
            new Student()
            {
                FirstName = "Cem",
                LastName = "Tekulus",
                StudentID = "1910206503"
            },
            new Student()
            {
                FirstName = "Yasin",
                LastName = "Mersin",
                StudentID = "1910206504"
            },
            new Student()
            {
                FirstName = "Berkin",
                LastName = "Topaloğlu",
                StudentID = "1910206505"
            }
        };

        public IActionResult GetStudentList()
        {
            return View(students);
        }

        [HttpPost]
        public IActionResult AddStudent(Student newStudent)
        {
            students.Add(newStudent);
            return View("GetStudentList", students);
        }

    }
}
