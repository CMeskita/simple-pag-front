using Dashboard.Data.Repositorios;
using Dashboard.Models.Dto;
using Dashboard.Models.Interface;
using Helpdesk.Data.Repositorios;
using Helpdesk.Models.Dto;
using Helpdesk.Models.Entity;
using Helpdesk.Models.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Helpdesk.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteRespositorio _clienteRepositorio;

        public ClienteController(IClienteRespositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        public IActionResult Index()
        {
            IList<Cliente> response = _clienteRepositorio.GetAll();
            if (response == null)
            {
                return RedirectToAction("Create");
            }
            List<Cliente> clientes = new List<Cliente>();
            foreach (var item in response)
            {
                if (item.Status == true)
                {
                    clientes.Add(item);
                }
            }
            return View(clientes);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Add(ClienteViewModel cliente)
        {
            if (ModelState.IsValid)
            {
                var result = _clienteRepositorio.ExisteCliente(cliente.Email);

                if (cliente.Lgpd == false)
                {

                    return RedirectToAction("Lgpd", new { cliente.Lgpd });
                }

                if (result == false)
                {
                    _clienteRepositorio.Add(cliente);
                    ModelState.Clear();
                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("Create", "Cliente", new { result });

                }

            }
            return View("Create");

        }
        public IActionResult Edit(string id)
        {
            var response = _clienteRepositorio.FindById(id).Result;
            return View(response);

        }
        public IActionResult EditCliente(ClienteViewModelUpdate cliente)
        {
            var response = _clienteRepositorio.UpdateAsync(cliente);

            return RedirectToAction("Index", "Cliente");

        }
        public IActionResult Inativar(string id)
        {
            var response = _clienteRepositorio.Inativar(id);
            return RedirectToAction("Index", "Cliente");

        }
    }
}
