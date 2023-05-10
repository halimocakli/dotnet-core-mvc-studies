using Microsoft.AspNetCore.Mvc;

namespace GettingDataViaForms_UsingTagHelpers.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Application is running. Getting data via HTML Forms using Tag Helpers.";
        }
    }
}
