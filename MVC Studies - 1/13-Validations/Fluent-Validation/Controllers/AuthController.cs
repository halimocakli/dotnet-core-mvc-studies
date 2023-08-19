using Fluent_Validation.Enums;
using Fluent_Validation.Models;
using Fluent_Validation.RepositoryPattern.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OAuth.Claims;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Fluent_Validation.Controllers
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
        public async Task<IActionResult> Login(AppUser user)
        {
            if (_userRepository.Any(x => x.UserName == user.UserName && x.Status != DataStatus.Deleted))
            {
                AppUser selectedUser = _userRepository.Default(x => x.UserName == user.UserName && x.Status != DataStatus.Deleted);
                bool isValid = BCrypt.Net.BCrypt.Verify(user.Password, selectedUser.Password);

                if (isValid)
                {
                    List<Claim> claims = new List<Claim>()
                    {
                        new Claim("userName", selectedUser.UserName),
                        new Claim("userId", selectedUser.Id.ToString()),
                        new Claim("role", selectedUser.Role.ToString())
                    };
                    ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    ClaimsPrincipal principal = new ClaimsPrincipal(identity);

                    await HttpContext.SignInAsync(principal);

                    if (selectedUser.Role == Role.Administrator)
                    {
                        return RedirectToAction("Index", "Home", new { area = "Management" });
                    }
                    else if (selectedUser.Role == Role.User)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
            }

            return View();
        }

        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }
    }
}
