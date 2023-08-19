using IocContainer_Logging.Services;
using IocContainer_Logging.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IocContainer_Logging.Controllers
{
    public class HomeController : Controller
    {
        // Dependency Injection
        // ConsoleLogger _log;
        ILog _log;
        public HomeController(ILog log)
        {
            _log = log;
        }

        public string Index()
        {
            //ConsoleLogger log = new ConsoleLogger();
            //log.Info("Yeni bir istek gelmiştir");

            _log.Info("Index Controller'ı içerisine yeni bir istek gelmiştir");

            return "Service is running.";
        }
    }
}
