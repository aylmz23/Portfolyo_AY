using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Portfolyo_AY.Data;
using Portfolyo_AY.Entities;
using System.Security.Claims;
using Portfolyo_AY.Enums;

namespace Portfolyo_AY.Controllers
{
    public class LoginController : Controller
    {
        MsSqlContext _context = new MsSqlContext();
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(AppUser appuser)
        {
            var loginUser = _context.AppUsers.FirstOrDefault(x => x.UserName == appuser.UserName && x.UserPassword == appuser.UserPassword );

            if (loginUser != null)
            {
                var ClaimList = new List<Claim>
                {
                new Claim(ClaimTypes.Name, loginUser.UserName),
                new Claim(ClaimTypes.NameIdentifier, loginUser.Id.ToString()),
                new Claim(ClaimTypes.Role, Enum.GetName(typeof(RoleType),loginUser.AppRoleId))
                };

                var claimsIdentity = new ClaimsIdentity(ClaimList, CookieAuthenticationDefaults.AuthenticationScheme);

                var authProperties = new AuthenticationProperties
                {};

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,new ClaimsPrincipal(claimsIdentity),authProperties); 
                return RedirectToAction("Index","Admin");
            }

           ModelState.AddModelError("","Kullanıcı Adı veya Şifre Yanlış!");
            return View(appuser);    
        }

        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index","Main");
        }
    }
}

