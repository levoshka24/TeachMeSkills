using Microsoft.AspNetCore.Mvc;
using Ritual.Models;
using System.Diagnostics;

namespace Ritual.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationContext db;

        public HomeController(ILogger<HomeController> logger, ApplicationContext db)
        {
            _logger = logger;
            this.db = db;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Main()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Main(UserOrder us)
        {
            db.USersOrders.Add(us);
            db.SaveChanges();
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
            var table_salfetki = db.Products.Where(u => u.Name == "Пасхальные салфетки").ToList();
            return View(table_salfetki);
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product pr)
        {
            db.Products.Add(pr);
            db.SaveChanges();
            return RedirectToAction("Admin");
        }
        public IActionResult Admin()
        {
            return View();
        }
        public IActionResult Kitchen()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Order()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Order(MainOrder ord)
        {
            db.MainOrders.Add(ord);
            db.SaveChanges();
            return RedirectToAction("Main");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}