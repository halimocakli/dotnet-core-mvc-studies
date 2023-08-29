using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Contracts;


namespace StoreApp.Controllers
{
    public class CategoryController : Controller
    {
        // Aşağıdaki yapı ile Dependency Injection gerçekleştiriyoruz.
        private readonly IRepositoryManager _manager;
        public CategoryController(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public IEnumerable<Category> Index()
        {
            return _manager.Category.FindAll(false);
        }
    }
}