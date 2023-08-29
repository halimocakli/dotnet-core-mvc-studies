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
        // Model Binding ile elde edilen _id değeri, Product modeli içerisinde aranıyor ve elde edilen ilk değer View'a gönderiliyor.
        public IActionResult Get(int id)
        {
            Product? product = _manager.Product.GetAllProducts(false).First(p => p.ProductId.Equals(id));
            return View(product);
        }
    }
}