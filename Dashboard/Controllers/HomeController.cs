using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Dashboard.Models;
using Dashboard.Models.Interface;

namespace Dashboard.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IFinalizadoraRepositorio _finalizadoraRepositorio;
        public HomeController(ILogger<HomeController> logger, IFinalizadoraRepositorio finalizadoraRepositorio)
        {
            _logger = logger;
            _finalizadoraRepositorio = finalizadoraRepositorio;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Dashboard()
        {
            return View();
        }
        [HttpGet]
        public decimal TotalPagamentos()
        {
            var result = _finalizadoraRepositorio.TotalPagamentos();
            return result;
        }
        [HttpGet]
        public decimal TotalQtdePagamentos()
        {
            var result = _finalizadoraRepositorio.TotalQtdePagamentos();
            return result;
        }
        [HttpGet]
        public decimal TotalPagamentosAvista()
        {
            var result = _finalizadoraRepositorio.TotalPagamentosAvista();
            return result;
        }
        [HttpGet]
        public decimal TotalPagamentosAprazo()
        {
            var result = _finalizadoraRepositorio.TotalPagamentosAPrazo();
            return result;
        }
    }
}
