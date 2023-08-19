using Microsoft.AspNetCore.Mvc;
using PassingDataUsingViewModel.Models;
using PassingDataUsingViewModel.Models.ViewModel;
using System;
using System.Collections.Generic;

namespace PassingDataUsingViewModel.Controllers
{
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
        public IActionResult PassingDataUsingViewModel()
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
    }
}
