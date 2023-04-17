using Microsoft.AspNetCore.Mvc;

namespace FirstNetCore.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "HomeController => Uygulama çalışıyor...";
        }

        public string Test()
        {
            return "Bu bir test action'udur.";
        }
        public IActionResult Greetings()
        {
            //ViewResult view_result = View();
            //return view_result;

            // View() metodu Controller sınıfı içerisinde tanımlıdır.
            // View() metodu default olarak View katmanına gider ve Greetings view'ını arar.
            // Rota ->> Views/Home/Greetings.cshtml
            return View();
        }
        public IActionResult SecondGreetings()
        {
            return View();
        }

        public IActionResult RandomName() 
        {
            return View("TestView");
        }
    }
}
