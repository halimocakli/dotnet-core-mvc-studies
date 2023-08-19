using Login_İşlemleri.Models;
using Login_İşlemleri.RepositoryPattern.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Login_İşlemleri.Controllers
{
    public class AuthController : Controller
    {
        IRepository<AppUser> _userRepository;
        public AuthController(IRepository<AppUser> userRepository)
        {
            _userRepository = userRepository;
        }

        public IActionResult Login()
        {
            return View();
        }

        /*
         * 1- Veri tabanında ilgili kullanıcı mevcut mu?
         * 2- Kullanıcının bilgilerini çek.
         * 3- Kullanıcın şifresi, kripte edilen veri ile eşleşiyor mu?
         * 4- Kullanıcının rolüne göre sayfa yönlendirmesini gerçekleştir.
         */

        [HttpPost]
        public IActionResult Login(AppUser user)
        {
            if (_userRepository.Any(x => x.UserName == user.UserName && x.Status != Enums.DataStatus.Deleted))
            {
                AppUser selectedUser = _userRepository.Default(x => x.UserName == user.UserName && x.Status != Enums.DataStatus.Deleted);
                bool isValid = BCrypt.Net.BCrypt.Verify(user.Password, selectedUser.Password);

                if (isValid)
                {
                    if (selectedUser.Role == Enums.Role.Administrator)
                    {
                        return RedirectToAction("Index", "Home", new { area = "Management" });
                    }
                    else if (selectedUser.Role == Enums.Role.User)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
            }

            return View();
        }
    }
}
