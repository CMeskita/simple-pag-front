using Dashboard.Models.Dto;
using Dashboard.Models.Entity;
using Dashboard.Models.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Dashboard.Controllers
{
    public class FinalizadoraController : Controller
    {
        private readonly IPagamentoRepositorio _pagamentoRepositorio;
        private readonly IFinalizadoraRepositorio _finalizadoraRepositorio;

        public FinalizadoraController(IPagamentoRepositorio pagamentoRepositorio, IFinalizadoraRepositorio finalizadoraRepositorio)
        {
            _pagamentoRepositorio = pagamentoRepositorio;
            _finalizadoraRepositorio = finalizadoraRepositorio;
        }

        public IActionResult Index()
        {
            IList<Finalizadora> response = _finalizadoraRepositorio.GetAllFinalizadoras();
            return View(response);
        }
        public IActionResult Create()
        {
            string[] array = { "Crédito", "Debito" };
            ViewBag.FormaPagamento = _pagamentoRepositorio.GetAllPagamentos();
            ViewBag.Modalidade = array;
            return View();
        }
        public IActionResult Add(DtoFinalizadora finalizadora)
        {
            var pagamento = _pagamentoRepositorio.FindPagamentoById(finalizadora.FormaPagamento).Result;
            if (ModelState.IsValid)
            {
                finalizadora.FormaPagamento = pagamento.Nome;

                var response = _finalizadoraRepositorio.AddFinalizadora(finalizadora).Result;
                ModelState.Clear();

                DtoFinalizadoraPagamento dtoFinalizadoraPagamento = new DtoFinalizadoraPagamento();
                dtoFinalizadoraPagamento.FinalizadoraId = response.Id.ToString();
                dtoFinalizadoraPagamento.FormaPagamentoId = finalizadora.FormaPagamento;
                dtoFinalizadoraPagamento.Sigla = pagamento.Sigla;
                dtoFinalizadoraPagamento.Modalidade=finalizadora.Modalidade;
                dtoFinalizadoraPagamento.AtualizarStatusPagamento(Convert.ToDateTime(finalizadora.Vencimento));
                
                _finalizadoraRepositorio.AddFinalizadoraPagamento(dtoFinalizadoraPagamento);

                return RedirectToAction("Create");

            }
            return RedirectToAction("Create");
        }
    }
}
