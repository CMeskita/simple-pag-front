using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Dashboard.Models;

namespace Dashboard.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
      
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
           
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
            var result = 0;
            return result;
        }
        [HttpGet]
        public decimal TotalQtdePagamentos()
        {
            var result = 0;
            return result;
        }
        [HttpGet]
        public decimal TotalPagamentosAvista()
        {
            var result = 0;
            return result;
        }
        [HttpGet]
        public decimal TotalPagamentosAprazo()
        {
            var result = 0;
            return result;
        }
        // Endpoint: /Home/ObterMetricasHelpdesk
        public IActionResult ObterMetricasHelpdesk()
        {
            return Json(new
            {
                abertos = 12,
                emAndamento = 5,
                resolvidos = 84,
                taxaSla = 92
            });
        }

        // Endpoint: /Home/ObterDadosGraficoMensal
        public IActionResult ObterDadosGraficoMensal()
        {
            // Retorna os meses estruturados para o Morris.js ler
            return Json(new[] {
        new { mes = "Jan", criados = 45, resolvidos = 40 },
        new { mes = "Fev", criados = 55, resolvidos = 48 },
        new { mes = "Mar", criados = 70, resolvidos = 65 },
        new { mes = "Abr", criados = 60, resolvidos = 58 }
    });
        }
    }
}
