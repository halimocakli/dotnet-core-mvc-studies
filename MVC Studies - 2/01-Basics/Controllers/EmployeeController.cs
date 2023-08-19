using _01_Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace _01_Basics.Controllers
{
    public class EmployeeController : Controller
    {
        // Çağırıldığı zaman geriye String değer döner.
        // Herhangi bir HTML rendering işlemi gerçekleşmez
        public string Index()
        {
            return "Hello World.";
        }
        // Dinamik veri gönderiyoruz.
        // @model string ifadesi, HTML tarafında gönderdiğimiz veriyi karşılayacak.
        // View() metoduna "message" değişkenini direkt veremeyiz çünkü string tipindeki değişkeni View ismi olarak algılıyor.
        // Önce string olacak şekilde View adını sonra da message değişkenini metoda parametre olarak vermemiz lazım.
        public IActionResult FirstIndex()
        {
            string message = $"This is First Index's Message -> {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}";
            return View("FirstIndex", message);
        }
        // View metoduna verdiğimiz parametre bir string dizisi olduğu için View ismini vermemize  gerek yok.
        public ViewResult SecondIndex()
        {
            string[] names = new string[]
            {
                "Halim",
                "Can",
                "Iraz"
            };
            return View(names);
        }
        public IActionResult ThirdIndex()
        {
            return Content("Employee with ThirdIndex");
        }
        public IActionResult FourthIndex()
        {
            List<Employee> employeeList = new List<Employee>()
            {
                new Employee()
                {
                    Id=1,
                    FirstName = "Iraz",
                    LastName = "Dogan",
                    Age = 24
                },
                new Employee()
                {
                    Id=2,
                    FirstName = "Halim Can",
                    LastName = "Ocaklı",
                    Age = 25
                },
                new Employee()
                {
                    Id=3,
                    FirstName = "Oğuzhan",
                    LastName = "Deniz",
                    Age = 22
                }
            };
            return View("FourthIndex", employeeList);
        }
    }
}