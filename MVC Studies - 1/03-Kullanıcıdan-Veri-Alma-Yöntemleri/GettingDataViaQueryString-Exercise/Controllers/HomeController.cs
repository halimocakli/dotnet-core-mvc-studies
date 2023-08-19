using Microsoft.AspNetCore.Mvc;

namespace GettingDataViaQueryString_Exercise.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Application is running. Getting data via Query string according to category name.";
        }
    }
}
