using Microsoft.AspNetCore.Mvc;
using PassingData.Models;
using PassingData.Models.ViewModel;
using System;
using System.Collections.Generic;

namespace PassingData.Controllers
{
    // Birden fazla nesneyi tek bir sınıf türünden nesneye aktarıp bu nesneyi de View'e göndermek.
    // Amaç Model'e birden fazla nesne vererek birden fazla nesneyi View'a iletebilmek.
    public class CustomerController : Controller
    {
        List<Customer> customers = new List<Customer>()
        {
            new Customer()
            {
                FirstName = "Halim Can",
                LastName = "Ocaklı",
                City = "İstanbul"
            },
            new Customer()
            {
                FirstName = "Raziye",
                LastName = "Dogan",
                City = "Ankara"
            },
            new Customer()
            {
                FirstName = "Oğuzhan",
                LastName = "Deniz",
                City = "Erzurum"
            },
            new Customer()
            {
                FirstName = "Batın Berkin",
                LastName = "Topaloğlu",
                City = "Şiran"
            }
        };
        public IActionResult UseViewModel()
        {
            Product product = new Product();
            product.ProductName = "Monitor";
            product.CategoryName = "Electronics";
            product.UnitPrice = 1500;

            string date = DateTime.Now.ToString();

            CustomerAndProductVM customerAndProduct = new CustomerAndProductVM();
            customerAndProduct.customers = customers;
            customerAndProduct.product = product;
            customerAndProduct.date = date;

            return View(customerAndProduct);
        }

        // Model'a birden fazla veri göndermek için Tuple'da kullanabiliriz.
        public IActionResult UseTuple()
        {
            Product product = new Product();
            product.ProductName = "Telephone";
            product.CategoryName = "Electronics";
            product.UnitPrice = 1500;

            string date = DateTime.Now.ToString();

            (List<Customer>, Product, string) customerAndProduct = (customers, product, date);

            return View(customerAndProduct);
        }
    }
}
