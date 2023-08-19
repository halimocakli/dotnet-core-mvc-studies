using Microsoft.AspNetCore.Mvc;

namespace PassingDataUsingViewBag.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "PassingDataUsingViewBag ->> Controllers ->> HomeController ->> UYGULAMA ÇALIŞIYOR";
        }
    }
}
