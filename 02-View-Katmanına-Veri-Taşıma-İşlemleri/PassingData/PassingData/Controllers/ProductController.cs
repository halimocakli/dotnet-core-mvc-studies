using Microsoft.AspNetCore.Mvc;
using PassingData.Models;
using System;
using System.Collections.Generic;

namespace PassingData.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            string user_name = "Halim Can";
            return View(user_name as Object);   // View() metodu içerisindeki Oveloadlara bakın. İlki View ismini string olarak istiyor, diğeri Model objesi alıyor.
        }

        public IActionResult ShowProduct()
        {
            Product product = new Product();

            product.ProductName = "Television";
            product.UnitPrice = 20;

            // View katmanına gönderdiğimiz veri Object tipinde.
            return View(product);
        }

        public IActionResult GetProductList()
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

            return View(products);
        }
    }
}
