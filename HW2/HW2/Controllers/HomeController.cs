using HW2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HW2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        Production[] products;
        public HomeController(ILogger<HomeController> logger)
        {
            products = new Production[]
            {
                new Production(1,"milk","20","25"),
                new Production(2,"cola","19","25"),
                new Production(3,"fanta","17","25"),
                new Production(4,"sprite","16","25"),
                new Production(5,"fanta","14","25"),
            };
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Form(string username, string password)
        {
            string login = "admin";
            string password2 = "admin";
            if (login.Equals(username) && password.Equals(password2))
            {
                return RedirectToAction("ShowProduction", "Home");
            }
            else
            {
                return RedirectToAction("Registration", "Home");
            }
        }
        
        public IActionResult ShowProduction()
        {
            return View(products);
        }
               
        
        public IActionResult Registration()
        {
            return View();
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
    }
}