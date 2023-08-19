using Microsoft.AspNetCore.Mvc;
using GettingDataViaRoute.Models;

namespace GettingDataViaRoute.Controllers
{
    public class HomeController : Controller
    {
        public string Index(string id, string productname)
        {
            return "Application is running. Getting data from route. Parameters: id(string), productname(string).";
        }

        public string GetDataWithClass(Product product)
        {
            return "Application is running. Getting data from route with class. Parameters: product(class)";
        }
    }
}
