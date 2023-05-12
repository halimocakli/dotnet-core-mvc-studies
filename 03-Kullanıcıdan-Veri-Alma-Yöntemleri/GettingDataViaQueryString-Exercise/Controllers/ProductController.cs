using GettingDataViaQueryString_Exercise.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GettingDataViaQueryString_Exercise.Controllers
{
    public class ProductController : Controller
    {
        List<Product> products = new List<Product>()
        {
            new Product(){ID=1, ProductName="Televizyon", CategoryName="Elektronik"},
            new Product(){ID=2, ProductName="Araba", CategoryName="Otomobil"},
            new Product(){ID=3, ProductName="Kalem", CategoryName="Kırtasiye"},
            new Product(){ID=4, ProductName="Saat", CategoryName="Aksesuar"},
            new Product(){ID=5, ProductName="Cep Telefonu", CategoryName="Elektronik"},
            new Product(){ID=6, ProductName="Kablosuz Kulaklık", CategoryName="Elektronik"},
            new Product(){ID=7, ProductName="Avize", CategoryName="Ev Eşyası"},
            new Product(){ID=8, ProductName="Buz Dolabı", CategoryName="Beyaz Eşya"},
            new Product(){ID=9, ProductName="Çamaşır Makinesi", CategoryName="Beyaz Eşya"},
            new Product(){ID=10, ProductName="Çalışma Masası", CategoryName="Ev Eşyası"}
        };
        public IActionResult GetProductWithCategoryName(string categoryName)
        {
            List<Product> productList = products.FindAll(x => x.CategoryName == categoryName);

            if (productList.Count == 0)
            {
                ViewBag.Error = "Girdiğiniz Kategori Adı ile eşleşen herhangi bir ürün bulunamadı.";
            }

            return View(productList);
        }
    }
}
