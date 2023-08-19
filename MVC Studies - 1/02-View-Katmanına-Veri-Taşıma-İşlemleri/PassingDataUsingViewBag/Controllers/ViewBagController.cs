using Microsoft.AspNetCore.Mvc;
using PassingDataUsingViewBag.Models;
using System.Collections.Generic;

namespace PassingDataUsingViewBag.Controllers
{
    public class ViewBagController : Controller
    {
        List<User> users = new List<User>()
            {
                new User()
                {
                    FirstName = "Halim Can",
                    LastName = "Ocaklı",
                    UserName = "halimaga"
                },
                new User()
                {
                    FirstName = "Raziye",
                    LastName = "Dogan",
                    UserName = "ıyaş"
                },
                new User()
                {
                    FirstName = "Oğuzhan",
                    LastName = "Deniz",
                    UserName = "sarıbaba"
                },
                new User()
                {
                    FirstName = "Batın Berkin",
                    LastName = "Topaloğlu",
                    UserName = "partalcı"
                }
            };
        public IActionResult PassingDataViewBag()
        {
            ViewBag.PassedUsers = users;
            return View();
        }
    }
}
