using Microsoft.AspNetCore.Mvc;
using Ritualka.Models;
using System.Diagnostics;

namespace Ritualka.Controllers
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
        public IActionResult Main()
        {
            return View();
        }
        public IActionResult Katalog()
        {
            return View();
        }
        public IActionResult Privacy()
        {
           
            return View();
        }
        public IActionResult Policy()
        {
            return View();
        }
        public IActionResult Personal()
        {
            return View();
        }
        public IActionResult Salfetki()
        {
            return View();
        }
        public IActionResult Kitchen()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}