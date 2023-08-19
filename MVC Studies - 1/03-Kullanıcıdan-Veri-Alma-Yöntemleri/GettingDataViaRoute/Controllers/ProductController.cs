using GettingDataViaRoute.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GettingDataViaRoute.Controllers
{
    public class ProductController : Controller
    {
        List<Product> products = new List<Product>()
        {
            new Product()
            {
                ID=1,
                ProductName="Televizyon",
                CategoryName="Elektronik"
            },
            new Product()
            {ID=2,
                ProductName="Araba",
                CategoryName="Otomobil"
            },
            new Product()
            {ID=3,
                ProductName="Kalem",
                CategoryName="Kırtasiye"
            },
            new Product()
            {
                ID=4,
                ProductName="Saat",
                CategoryName="Aksesuar"
            }
        };
        public IActionResult GetAllProducts()
        {
            return View(products);
        }
        public IActionResult GetProductById(int id)
        {
            Product product = products.Find(x => x.ID == id);

            if (product == null)
            {
                ViewBag.Error = "Girdiğiniz ID ile eşleşen herhangi bir ürün bulunamadı.";
            }

            return View(product);
        }
    }
}
