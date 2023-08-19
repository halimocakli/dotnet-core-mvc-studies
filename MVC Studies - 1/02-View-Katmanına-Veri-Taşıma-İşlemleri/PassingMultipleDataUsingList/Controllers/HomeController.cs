using Microsoft.AspNetCore.Mvc;

namespace PassingMultipleDataUsingList.Controllers
{
    public class HomeController : Controller
    {
        // Uygulamayı çalıştırdığımızda ilk olarak aşağıdaki metot tetiklenir.
        // Startup dosyası üzerinde MapDefaultControllerRoute() metodu sebebiyle ilk olarak aşağıdaki metot çalışır.
        public string Index()
        {
            return "PassingMultipleDataUsingList ->> Controllers ->> HomeController ->> Index() Metodu ->> UYGULAMA ÇALIŞIYOR";
        }
    }
}
