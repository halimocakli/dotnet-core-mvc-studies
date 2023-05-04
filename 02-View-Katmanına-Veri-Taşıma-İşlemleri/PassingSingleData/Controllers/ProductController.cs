using Microsoft.AspNetCore.Mvc;
using System;

namespace PassingSingleData.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            string user_name = "Halim Can";

            // View() metodu içerisindeki oveload'lara bakın.
            // İlki View ismini string olarak istiyor, diğeri ise Object türünde bir değişken alıyor.
            // Biz burada View'e object türünde bir değişken göndermek için type casting gerçekleştiriyoruz.
            return View(user_name as Object);
        }
    }
}
