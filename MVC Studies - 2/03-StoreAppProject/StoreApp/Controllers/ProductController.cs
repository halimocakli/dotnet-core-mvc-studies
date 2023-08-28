using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repositories;

namespace StoreApp.Controllers
{
    public class ProductController : Controller
    {
        // Aşağıdaki yapıyı kullanarak veritabanındaki verilere erişmeye çalışıyoruz ancak bu kullanım pek uygun değil.
        // Halihazırda Program.cs dosyasında oluşturduğumuz servisi aşağıdaki yapı özelinde kullanamıyoruz.
        // Bununla birlikte dosya yolunu direkt olarak Controller dosyasında belirterek iyi bir kodlama tekniği kullanmamış oluyoruz.
        // Bu noktada devreye "Dependency Injection" giriyor.
        // ---------------------------------------------------------------------------------------------------------------------------
        // public IEnumerable<Product> Index()
        // {
        //     var context = new RepositoryContext(
        //         new DbContextOptionsBuilder<RepositoryContext>()
        //         .UseSqlite("Data Source = C:\\Users\\GLB90101552\\Desktop\\MVC\\00-Database\\StoreAppProjectDB\\ProductDb.db")
        //         .Options);

        //     return context.Products;
        // }

        // Aşağıdaki yapı ile Dependency Injection gerçekleştiriyoruz.
        private readonly RepositoryContext _context;
        public ProductController(RepositoryContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            if (_context.Products != null)
            {
                List<Product> productsModel = _context.Products.ToList();
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
            Product? product = _context.Products.First(p => p.ProductId.Equals(id));
            return View(product);
        }
    }
}