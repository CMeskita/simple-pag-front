using Dashboard.Models.Dto;
using Dashboard.Models.Entity;
using Dashboard.Models.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Dashboard.Controllers
{
    public class PagamentosController : Controller
    {
        private readonly IPagamentoRepositorio _pagamentoRepositorio;

        public PagamentosController(IPagamentoRepositorio pagamentoRepositorio)
        {
            _pagamentoRepositorio = pagamentoRepositorio;
        }
        public IActionResult Index()
        {
            IList<FormaPagamento> response = _pagamentoRepositorio.GetAllPagamentos();
            List<FormaPagamento> pagamentos = new List<FormaPagamento>();
            foreach (var item in response)
            {
                if (item.Status == true)
                {
                    pagamentos.Add(item);
                }
            }
            return View(pagamentos);
        }
        public IActionResult Create(bool result)
        {
            if (result == true)
            {
                ModelState.AddModelError("", "Forma de Pagamento Já Está Cadastrado ");

            }
            return View();
        }
        public IActionResult Add(DtoFormaPagamento pagamento)
        {
            if (ModelState.IsValid)
            {
                var result = _pagamentoRepositorio.ExistePagamento(pagamento.Sigla);
                if (result == false)
                {
                    _pagamentoRepositorio.AddPagamento(pagamento);
                    ModelState.Clear();
                }
                return RedirectToAction("Index");
            }
            return View("Create", pagamento);

        }

    }
}
