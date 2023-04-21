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
        // Key-Value mantığı ile çalışır.
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

        // İçerisinde Object tipinde değer tutar.
        // Key-Value mantığı ile çalışır.
        // Diğer yöntemlerden farklı olarak kendi View'ına veri taşımakla birlikte Action'dan Action'a veri taşır ve de Action'dan View'a veri taşır.
        // Tarayıcılardaki Cookie mantığını kullanır.
        // Bir sefere mahsus kullanılabilir.
        public IActionResult UserTempData()
        {
            TempData["Name"] = "Halim";

            // UserTempData actionunu atlayıp UserTempDataTest actionuna geçelim.
            return RedirectToAction("UserTempDataTest");

            // return View();
        }

        public IActionResult UserTempDataTest()
        {
            TempData.Keep("Name");  // TempData'nın birden fazla defa kullanılmasını sağlar.
            //string name = TempData["Name"].ToString();
            return View();
        }
    }
}
