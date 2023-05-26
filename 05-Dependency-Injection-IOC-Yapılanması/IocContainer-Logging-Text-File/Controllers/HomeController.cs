using IocContainer_Logging_Text_File.Services;
using IocContainer_Logging_Text_File.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IocContainer_Logging_Text_File.Controllers
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
            System.Threading.Thread.Sleep(2000);
            _log.Info("Index Controller'ı içerisine yeni bir istek gelmiştir");
            System.Threading.Thread.Sleep(2000);
            _log.Info("Index Controller'ı içerisine yeni bir istek gelmiştir");

            return "Service is running.";
        }
    }
}
