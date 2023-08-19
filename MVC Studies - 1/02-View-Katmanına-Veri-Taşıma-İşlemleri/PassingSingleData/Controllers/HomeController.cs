using Microsoft.AspNetCore.Mvc;

namespace PassingSingleData.Controllers
{
    public class HomeController : Controller
    {
        // Uygulamayı çalıştırdığımızda ilk olarak aşağıdaki metot tetiklenir.
        // Startup dosyası üzerinde MapDefaultControllerRoute() metodu sebebiyle ilk olarak aşağıdaki metot çalışır.
        public string Index()
        {
            return "PassingSingleData ->> Controllers ->> HomeController ->> Index() Metodu ->> UYGULAMA ÇALIŞIYOR";
        }
    }
}
