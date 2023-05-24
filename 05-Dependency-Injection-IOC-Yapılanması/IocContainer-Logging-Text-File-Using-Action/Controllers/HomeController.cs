using IocContainer_Logging_Text_File_Using_Action.Services;
using IocContainer_Logging_Text_File_Using_Action.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IocContainer_Logging_Text_File_Using_Action.Controllers
{
    public class HomeController : Controller
    {
        // Constructor üzerinden Dependency Injection
        ILog _log;
        public HomeController(ILog log)
        {
            _log = log;
        }

        // Action üzerinden Dependency Injection
        public string Index([FromServices] ILog log)
        {
            //ConsoleLogger log = new ConsoleLogger();
            //log.Info("Yeni bir istek gelmiştir");

            log.Info("Index Controller'ı içerisine Action bazlı yeni bir istek gelmiştir");
            System.Threading.Thread.Sleep(2000);
            log.Info("Index Controller'ı içerisine Action bazlı yeni bir istek gelmiştir");
            System.Threading.Thread.Sleep(2000);
            log.Info("Index Controller'ı içerisine Action bazlı yeni bir istek gelmiştir");

            return "Service is running.";
        }
    }
}
