
using Helpdesk.Models.Entity;
using Helpdesk.Models.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Helpdesk.Controllers
{
    public class SuporteController : Controller
    {
        private readonly ISuporteRepositorio _isuporteRepositorio;

        public SuporteController(ISuporteRepositorio isuporteRepositorio)
        {
            _isuporteRepositorio = isuporteRepositorio;
        }

        public IActionResult Index()
        {
            IList<Suporte> response = _isuporteRepositorio.GetAll();
            if (response == null)
            {
                return RedirectToAction("Create");
            }
            return View(response);
        }
        public IActionResult Create()
        {
            string[] modalidade = { "Crédito", "Debito" };
            string[] array = { "Crédito", "Debito" };
            ViewBag.FormaPagamento = array;
            ViewBag.Modalidade = modalidade;

            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SalvarSolucao(string id, string solucao, string status)
        {
            var atendimento = await _isuporteRepositorio.FindById(id);
            if (atendimento == null) return NotFound();

            // Injeta os dados de fechamento
            atendimento.Solucao = solucao;
            atendimento.Status = status;

            if (status == "Resolvido")
            {
                atendimento.DataFechamento = DateTime.Now; // Data atual (2026)
            }

            await _isuporteRepositorio.UpdateAsync(atendimento);

            return RedirectToAction(nameof(Index));
        }
    }
}
