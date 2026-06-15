using Dashboard.Models.Interface;
using Helpdesk.Data; // Seu DbContext aqui
using Helpdesk.Models.Entity;
using Helpdesk.Models.ViewModel;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Helpdesk.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public LoginController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logar(LoginViewModel model)
        {
            if (!ModelState.IsValid) return View("Login", model);
            var response = await _usuarioRepositorio.ExisteUsuarioEmail(model.Email);
            if (response != null && model.Email == response.Email && model.Senha == response.ChavePrivada)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, response.Nome),
                    new Claim(ClaimTypes.Email, response.Email),
                    new Claim("UsuarioId", response.Id.ToString()) 
                 };
 
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var authProperties = new AuthenticationProperties
                {
                    IsPersistent = true // Mantém o usuário logado mesmo se fechar o navegador (conforme expiração)
                };

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);

                return RedirectToAction("Index", "Home");
            }

   
            ModelState.AddModelError(string.Empty, "E-mail ou senha inválidos.");

         
            return View("Login", model);
        }
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Login");
        }
    }
}