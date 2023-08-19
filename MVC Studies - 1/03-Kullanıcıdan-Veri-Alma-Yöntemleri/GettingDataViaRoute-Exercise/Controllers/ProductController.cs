﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using GettingDataViaRoute_Exercise.Models;

namespace GettingDataViaRoute_Exercise.Controllers
{
    public class ProductController : Controller
    {
        List<Product> products = new List<Product>()
        {
            new Product(){ID=1, ProductName="Televizyon", CategoryName="Elektronik"},
            new Product(){ID=2, ProductName="Araba", CategoryName="Otomobil"},
            new Product(){ID=3, ProductName="Kalem", CategoryName="Kırtasiye"},
            new Product(){ID=4, ProductName="Saat", CategoryName="Aksesuar"}
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
