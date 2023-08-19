using IocContainer_Logging.Services.Interfaces;
using System;
using System.Reflection.Metadata;

namespace IocContainer_Logging.Services
{
    public class TextLogger : ILog
    {
        public void Info(string message)
        {
            Console.WriteLine("Dosyaya yazılan mesaj: " + message);
        }
    }
}
