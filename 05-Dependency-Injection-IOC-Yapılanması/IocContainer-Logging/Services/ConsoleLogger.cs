using IocContainer_Logging.Services.Interfaces;
using System;

namespace IocContainer_Logging.Services
{
    public class ConsoleLogger : ILog
    {
        public void Info(string message)
        {
            Console.WriteLine(message);
        }
    }
}
