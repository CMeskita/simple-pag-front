using AspNetCoreHero.ToastNotification.Abstractions;
using Dashboard.Models;
using Dashboard.Models.Dto;
using Dashboard.Models.Interface;
using Data.Conexao;
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
            return View(response);
        }


        public IActionResult Create(bool result)
        {
           

            if (result == true)
            {
                ModelState.AddModelError("", "Usuário Já Está Cadastrado ");

            }

            return View();
        }
        [HttpPost]
        public IActionResult Add(DtoUsuario dto)
        {
          
           var  result=_usuarioRepositorio.ExisteUsuario(dto.Email);

            if (result==false)
            {
                _usuarioRepositorio.AddUsuario(dto);
                ModelState.Clear();
            }
            return RedirectToAction("Create", "Usuario", new { result });
        }
        public IActionResult Edit(string id)
        {
            var response = _usuarioRepositorio.FindUsuarioById(id).Result;
            return View(response);

        }
        public IActionResult EditUsuario(DtoUsuario dto)
        {
            var response = _usuarioRepositorio.UpdateAsync(dto);

            return RedirectToAction("Index", "Usuario");

        }
    }
}
