using Microsoft.AspNetCore.Mvc;
using PassingMultipleDataUsingClass.Models;

namespace PassingMultipleDataUsingClass.Controllers
{
    public class ProductController : Controller
    {
        // Models klasöründe oluşturduğumuz Product sınıfını örnekleyerek elde ettiğimiz veriyi View katmanına aktaralım.
        public IActionResult ShowProduct()
        {
            Product product = new Product();

            product.ProductName = "Television";
            product.UnitPrice = 20;
            product.CategoryName = "Electronics";

            // View katmanına gönderdiğimiz veri Object tipinde.
            return View(product);
        }
    }
}
