using Microsoft.AspNetCore.Mvc;
using PassingMultipleDataUsingList.Models;
using System.Collections.Generic;

namespace PassingMultipleDataUsingList.Controllers
{
    public class ProductController : Controller
    {
        List<Product> products = new List<Product>()
            {
                new Product()
                {
                    ProductName = "Computer",
                    UnitPrice = 9600,
                    CategoryName = "Electronics"
                },

                new Product()
                {
                    ProductName = "Mobil Phone",
                    UnitPrice = 3200,
                    CategoryName = "Electronics"
                },

                new Product()
                {
                    ProductName = "Refrigetor",
                    UnitPrice = 5000,
                    CategoryName = "White Appliances"
                },

                new Product()
                {
                    ProductName = "Chair",
                    UnitPrice = 500,
                    CategoryName = "Furniture"
                }
            };

        // Yukarıda, global olarak tanımlanan ve oluşturulan, Product tipinde veri tutan listeyi View katmanına gönderen metot.
        public IActionResult GetProductList()
        {
            return View(products);
        }
    }
}
