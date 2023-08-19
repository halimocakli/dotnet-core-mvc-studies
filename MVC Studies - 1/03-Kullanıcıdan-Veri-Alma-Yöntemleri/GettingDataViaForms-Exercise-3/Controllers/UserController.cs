using GettingDataViaForms_Exercise_3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GettingDataViaForms_Exercise_3.Controllers
{
    public class UserController : Controller
    {
        List<User> users = new List<User>()
        {
            new User()
            {
                FirstName = "Raziye",
                LastName = "Dogan",
                UserName = "raziyedogan",
                Email = "raziyedogan@gmail.com",
                Password = "raziyedogan123"
            },
            new User()
            {
                FirstName = "Halim Can",
                LastName = "Ocaklı",
                UserName = "halimcanocakli",
                Email = "halimcanocakli@gmail.com",
                Password = "halimcanocakli123"
            },
            new User()
            {
                FirstName = "Oğuzhan",
                LastName = "Deniz",
                UserName = "oguzhandeniz",
                Email = "oguzhandeniz@gmail.com",
                Password = "oguzhandeniz123"
            },
        };

        public IActionResult GetUserList()
        {
            return View(users);
        }

        [HttpPost]
        public IActionResult AddUser(User newUser)
        {
            users.Add(newUser);
            return View("GetUserList", users);
        }
    }
}
