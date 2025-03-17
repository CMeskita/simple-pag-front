using Dashboard.Models;
using Dashboard.Models.Dto;
using Dashboard.Models.Interface;
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
           

            if (result == true)
            {
                ModelState.AddModelError("", "Usuário Já Está Cadastrado ");

            }

            return View();
        }
   
        public IActionResult Add(DtoUsuario usuario)
        {
            if (!ModelState.IsValid) {
                var result = _usuarioRepositorio.ExisteUsuario(usuario.Email);

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
            return View("Create", usuario);

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
    }
}
