using Microsoft.AspNetCore.Mvc;

namespace PassingDataUsingTempDataAndTempDataTest.Controllers
{
    public class HomeController : Controller
    {
        // Uygulamayı çalıştırdığımızda ilk olarak aşağıdaki metot tetiklenir.
        // Startup dosyası üzerinde MapDefaultControllerRoute() metodu sebebiyle ilk olarak aşağıdaki metot çalışır.
        public string Index()
        {
            return "PassingDataUsingTempDataAndTempDataTest ->> Controllers ->> HomeController ->> Index() Metodu ->> UYGULAMA ÇALIŞIYOR";
        }
    }
}
