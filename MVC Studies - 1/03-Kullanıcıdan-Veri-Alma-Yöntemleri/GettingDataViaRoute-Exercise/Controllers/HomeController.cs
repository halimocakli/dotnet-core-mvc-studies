using Microsoft.AspNetCore.Mvc;

namespace GettingDataViaRoute_Exercise.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Application is running. Getting data by category name.";
        }
    }
}
