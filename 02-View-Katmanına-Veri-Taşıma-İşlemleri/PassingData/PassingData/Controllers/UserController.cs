using Microsoft.AspNetCore.Mvc;
using PassingData.Models;
using System.Collections.Generic;

namespace PassingData.Controllers
{
    public class UserController : Controller
    {
        // ViewBag ile Controller'dan View katmanına veri gönderme işlemi.
        // ViewBag dinamik tipte nesne yaratır. Bu tip, Runtime'a kadar hangi tipte veri tuttuğunu bilmez.

        public IActionResult UserViewBag()
        {
            User user = new User();

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

            // Viewbag nesnemizi oluşturalım
            ViewBag.Users = users;

            return View();
        }

        // ViewData yöntemi ile View katmanına veri gönderelim.
        // ViewData'da Object türünde değer tutulur. Bu değeri kullanmak için unboxing yapmalıyız.
        public IActionResult UserViewData() 
        {
            ViewData["UserName"] = "halimocakli";

            User user = new User();
            user.FirstName = "Halim Can";
            user.LastName = "Ocaklı";
            user.UserName = "halimaga";

            ViewData["User"] = user;

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

            ViewData["Users"] = users;

            return View();
        }
    }
}
