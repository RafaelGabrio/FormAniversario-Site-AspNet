using app2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace app2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ViewResult Index()
        {
            return View("inicio");
        }

        public ViewResult Formulario()
        {
            return View("Formulario");
        }
    }
}