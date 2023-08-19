using Microsoft.AspNetCore.Mvc;
using PassingDataUsingViewData.Models;
using System.Collections.Generic;

namespace PassingDataUsingViewData.Controllers
{
    public class ViewDataController : Controller
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

        // ViewData yöntemi ile View katmanına veri gönderelim.
        // ViewData'da Object türünde değer tutulur. Bu değeri kullanmak için unboxing yapmalıyız.
        // Key-Value mantığı ile çalışır.
        public IActionResult PassingSingleDataUsingViewData()
        {
            ViewData["UserName"] = "halimocakli";

            User user = new User();
            user.FirstName = "Halim Can";
            user.LastName = "Ocaklı";
            user.UserName = "halimaga";

            ViewData["User"] = user;

            return View();
        }

        public IActionResult PassingMultipleDataUsingViewData()
        {
            // Global alanda oluşturulan liste aktarılıyor.
            ViewData["Users"] = users;

            return View();
        }
    }
}
