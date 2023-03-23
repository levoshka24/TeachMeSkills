using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        ProductClass[] product;
        ProductClass[] product2;
        PersonView[] person;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            product = new ProductClass[]
            {
                new ProductClass(1,"milk","25","azya","prod"),
                new ProductClass(1,"milk","25","azya","prod"),
                new ProductClass(1,"milk","25","azya","prod"),
                new ProductClass(1,"milk","25","azya","prod")
            };
            
        }
        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public string Form(PersonView person)  
        {
            if (ModelState.IsValid)
            {
                return $"Username {person.Name}, Age - {person.Age}, Surname - {person.Surname}, Id - {person.Id}";
            }
            else
            {
                return "Данные не прошли";
            }
        }
        public IActionResult Index()
        {
            return View(product);
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