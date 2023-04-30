using GettingData.Models;
using Microsoft.AspNetCore.Mvc;

namespace GettingData.Controllers
{
    public class HomeController : Controller
    {
        public string Index(string id, string productname)
        {
            return "Application is running. Getting data from route.";
        }

        public string GetDataWithClass(Product product)
        {
            return "Application is running. Getting data from route with class";
        }
    }
}
