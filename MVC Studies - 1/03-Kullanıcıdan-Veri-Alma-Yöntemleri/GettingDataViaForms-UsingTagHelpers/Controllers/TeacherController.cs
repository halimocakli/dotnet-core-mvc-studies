using GettingDataViaForms_UsingTagHelpers.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GettingDataViaForms_UsingTagHelpers.Controllers
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
            return View();
        }

        [HttpPost]
        public IActionResult AddTeacher(Teacher teacher)
        {
            ViewBag.Branches = branches;
            return View();
        } 
    }
}
