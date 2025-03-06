using Microsoft.AspNetCore.Mvc;

namespace Dashboard.Controllers
{
    public class FinalizadoraController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
