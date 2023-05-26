using IocContainer_Logging_Text_File_Using_Action.Services.Interfaces;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;
using System.Reflection.Metadata;
using System.Text;

namespace IocContainer_Logging_Text_File_Using_Action.Services
{
    public class TextLogger : ILog
    {
        string path;
        public TextLogger(IHostEnvironment environment)
        {
            try
            {
                string date = DateTime.Now.ToString("dd-MM-yyyy");
                path = $"{environment.ContentRootPath}/Logs/{date}.txt";

                if (!File.Exists(path))
                {
                    using (File.Create(path)) { };
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Info(string message)
        {
            try
            {
                using (StreamWriter stream = new StreamWriter(path, true, Encoding.UTF8))
                {
                    string time = DateTime.Now.ToString("HH:mm:ss");
                    stream.WriteLine($"## INFO ## || && {time} && || Message: {message}");
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
