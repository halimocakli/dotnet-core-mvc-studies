using Microsoft.AspNetCore.Mvc;
using PassingMultipleDataUsingTuple.Models;
using System;
using System.Collections.Generic;

namespace PassingMultipleDataUsingTuple.Controllers
{
    public class TupleController : Controller
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
        public IActionResult PassingDataUsingTuple()
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
