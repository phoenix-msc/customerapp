using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using PhoenixCust.CodeFirstEntities;
using PhoenixCust.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PhoenixCust.Controllers
{
    public class AccountController : Controller
    {
        private readonly CodeFirstContext _context;
        public AccountController(CodeFirstContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Login()
        {
            var loginViewModel = new LoginViewModel();
            return View(loginViewModel);
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel loginViewModel)
        {
            return null;

        }
        public bool Login(string email, string password)
        {
            var customer = _context.CodeFirstCustomers.Where(i => i.Custemailaddress.ToLower() == email.ToLower() && i.Password == password).FirstOrDefault();
            if (customer != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, customer.Id.ToString())
                };
                var claimidentity = new ClaimsIdentity
                    (claims, CookieAuthenticationDefaults.AuthenticationScheme);
                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimidentity));

                return true;

            }
            else
            {
                return false;
            }
        }
    }
}
