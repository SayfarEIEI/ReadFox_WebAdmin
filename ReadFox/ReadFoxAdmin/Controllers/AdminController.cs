using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using ReadFoxAdmin.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ReadFoxAdmin.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(string user, string password)
        {
            if (string.IsNullOrEmpty(user))
            {
                return RedirectToAction(nameof(Index));
            }
            if (string.IsNullOrEmpty(password))
            {
                return RedirectToAction(nameof(Index));
            }
            if (user == "admin" && password == "admin")
            {
                var claim = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, user),
                    new Claim(ClaimTypes.Role, "admin")
                }, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(claim);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction(nameof(Index));
        }
        public IActionResult ErrorForbidden()
        {
            return View();
        }

        public static string Passwords(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        } 
        public static bool CheckPassword(string password, string hashPassword)
        {
            return BCrypt.Net.BCrypt.Verify(password, hashPassword);
        }
    }
}
