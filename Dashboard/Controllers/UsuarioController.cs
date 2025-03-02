using Dashboard.Models.Dto;
using Dashboard.Models.Interface;
using Data.Conexao;
using Microsoft.AspNetCore.Mvc;

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
            return View();
        }

        public IActionResult Create(DtoUsuario dto)
        {
            _usuarioRepositorio.AddUsuario(dto);
            return View();
        }
    }
}
