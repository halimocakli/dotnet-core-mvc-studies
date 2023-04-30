using Microsoft.AspNetCore.Mvc;

namespace GetDataWithCategoryName.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Application is running. Getting data by category name.";
        }
    }
}
