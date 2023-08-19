using Microsoft.AspNetCore.Mvc;
using FirstDotnetCoreImplementation.Models;

namespace FirstDotnetCoreImplementation.Controllers
{
    public class UserController : Controller
    {
        public IActionResult GetUser()
        {
            User user = new User(); // Model katmanındaki User sınıfına ulaştık.
            user.Name = "Halim Can";
            user.Surname = "Ocaklı";
            user.Phone = "+905417694139";
            user.ID = 1;

            return View();
        }

        /// <summary>
        /// Aşağıdaki metot, UserController içerisinde oluşturulsa da bir Action değildir.
        /// Bu nedenle [NonAction] attribute'u ile etiketlenir ve route yapısına dahil olmaz.
        /// Ancak bir Controller içersinde Action dışında bir yapı kullanmak mimari açısından yanlıştır.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [NonAction]
        public string GetFullName(User user)
        {
            return user.Name + " " + user.Surname;
        }
    }
}
