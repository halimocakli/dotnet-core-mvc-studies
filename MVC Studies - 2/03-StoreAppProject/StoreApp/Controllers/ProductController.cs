using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Contracts;


namespace StoreApp.Controllers
{
    public class ProductController : Controller
    {
        // Aşağıdaki yapı ile Dependency Injection gerçekleştiriyoruz.
        private readonly IRepositoryManager _manager;
        public ProductController(IRepositoryManager manager)
        {
            _manager = manager;
        }
        public IActionResult Index()
        {
            if (_manager.Product.GetAllProducts(false) != null)
            {
                List<Product> productsModel = _manager.Product.GetAllProducts(false).ToList();
                return View(productsModel);
            }
            else
            {
                return View();
            }
        }
        public IActionResult Get(int id)
        {
            Product? product = _manager.Product.GetProductById(id, false);
            return View(product);
        }
    }
}