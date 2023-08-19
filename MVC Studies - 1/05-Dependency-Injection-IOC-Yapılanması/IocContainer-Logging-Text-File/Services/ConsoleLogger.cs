using IocContainer_Logging_Text_File.Services.Interfaces;
using System;

namespace IocContainer_Logging_Text_File.Services
{
    public class ConsoleLogger : ILog
    {
        public void Info(string message)
        {
            Console.WriteLine(message);
        }
    }
}
