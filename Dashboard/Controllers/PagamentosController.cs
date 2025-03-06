using Dashboard.Data.Repositorios;
using Dashboard.Models.Dto;
using Dashboard.Models.Interface;
using Microsoft.AspNetCore.Mvc;

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
            return View();
        }
        public IActionResult Create(bool result)
        {
            if (result == true)
            {
                ModelState.AddModelError("", "Forma de Pagamento Já Está Cadastrado ");

            }
            return View();
        }
        public IActionResult Add(DtoFormaPagamento dto)
        {
            var result = _pagamentoRepositorio.ExistePagamento(dto.Sigla);
            if (result == false)
            {
                _pagamentoRepositorio.AddPagamento(dto);
                ModelState.Clear();
            }
            return RedirectToAction("Create", "Pagamentos", new {result});
        }

    }
}
