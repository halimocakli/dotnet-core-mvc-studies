using Microsoft.AspNetCore.Mvc;

namespace GettingDataViaForms_ShowModelDataOnForm.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Application is running. Getting data via HTML Forms.";
        }
    }
}
