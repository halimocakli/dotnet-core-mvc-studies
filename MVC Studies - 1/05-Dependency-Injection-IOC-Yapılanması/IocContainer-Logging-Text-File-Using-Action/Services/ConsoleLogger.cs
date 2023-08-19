using IocContainer_Logging_Text_File_Using_Action.Services.Interfaces;
using System;

namespace IocContainer_Logging_Text_File_Using_Action.Services
{
    public class ConsoleLogger : ILog
    {
        public void Info(string message)
        {
            Console.WriteLine(message);
        }
    }
}
