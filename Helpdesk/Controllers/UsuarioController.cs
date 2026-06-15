
using Dashboard.Models.Dto;
using Dashboard.Models.Interface;
using Helpdesk.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Dashboard.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
  
        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
           
        }

        public IActionResult Index()
        {
            IList<Usuario> response = _usuarioRepositorio.GetAllUsuarios();
            if (response == null)
            {
                return RedirectToAction("Create");
            }
            List<Usuario>usuario=new List<Usuario>();
            foreach (var item in response)
            {
                if (item.Status==true)
                {
                    usuario.Add(item);
                }
            }
            return View(usuario);
        }
        public IActionResult Create(bool result)
        {
             ViewBag.Perfil = _usuarioRepositorio.GetAllPerfil();
            ViewBag.Setor = _usuarioRepositorio.GetAllSetor();
          

            if (result == true )
            {
                ModelState.AddModelError("", "Usuário Já Está Cadastrado ");

            }
       


            return View();
        }
        public IActionResult Lgpd(bool lgpd )
        {
            ViewBag.Perfil = _usuarioRepositorio.GetAllPerfil();
            ViewBag.Setor = _usuarioRepositorio.GetAllSetor();
            if (lgpd == false)
            {
                ModelState.AddModelError("", "Usuário Não está Ciente das leis de Proteção aos Dados! ");

            }


            return View("Create");
        }
        public IActionResult Add(UsuarioViewModel usuario)
        {
            if (ModelState.IsValid) {
                var result = _usuarioRepositorio.ExisteUsuario(usuario.Email);
              
                if (usuario.Lgpd==false)
                {

                    return RedirectToAction("Lgpd", new { usuario.Lgpd });
                }
              
                if (result == false)
                {
                    _usuarioRepositorio.AddUsuario(usuario);
                    ModelState.Clear();
                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("Create", "Usuario", new { result });

                }
                
            }
            return View("Create");

        }
        public IActionResult Edit(string id)
        {
            var response = _usuarioRepositorio.FindUsuarioById(id).Result;
            return View(response);

        }
        public IActionResult EditUsuario(DtoUsuarioUpdate usuario)
        {
            var response = _usuarioRepositorio.UpdateAsync(usuario);

            return RedirectToAction("Index", "Usuario");

        }
        public IActionResult Inativar(string id)
        {
            var response = _usuarioRepositorio.InativarUsuario(id);
            return RedirectToAction("Index", "Usuario");

        }
        public IActionResult Perfil()
        {
            // 1. Verifica se o usuário está realmente logado
            if (User.Identity.IsAuthenticated)
            {
                // 2. Pega o Nome (gravado via ClaimTypes.Name)
                string nome = User.Identity.Name;

                // 3. Pega o E-mail (gravado via ClaimTypes.Email)
                string email = User.FindFirst(System.Security.Claims.ClaimTypes.Email)?.Value;

                // 4. Pega o seu ID customizado (gravado como "UsuarioId")
                string usuarioId = User.FindFirst("UsuarioId")?.Value;

                // Exemplo de uso: Passando para a tela
                ViewBag.NomeUsuario = nome;
                ViewBag.IdUsuario = usuarioId;
            }

            return View();
        }
    }
}
