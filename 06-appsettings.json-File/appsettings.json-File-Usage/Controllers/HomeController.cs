using appsettings.json_File_Usage.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;

namespace appsettings.json_File_Usage.Controllers
{
    public class HomeController : Controller
    {
        readonly IConfiguration _configuration;
        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string Index()
        {
            string email = _configuration["Email"];
            string name = _configuration["User:Name"];
            string surname = _configuration["User:Surname"];
            string password = _configuration["User:Password"];

            Console.WriteLine();

            Console.WriteLine(email);
            Console.WriteLine(name);
            Console.WriteLine(surname);
            Console.WriteLine(password);

            email = _configuration.GetSection("Email").Value;
            name = _configuration.GetSection("User:Name").Value;
            surname = _configuration.GetSection("User:Surname").Value;
            password = _configuration.GetSection("User:Password").Value;

            Console.WriteLine();

            Console.WriteLine(email);
            Console.WriteLine(name);
            Console.WriteLine(surname);
            Console.WriteLine(password);

            // JSON objesini Class'a dönüştürme.
            User user = _configuration.GetSection("User").Get(typeof(User)) as User;

            return "Application is running";
        }
    }
}
