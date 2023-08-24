using Microsoft.AspNetCore.Mvc;
using Ritualka.Models;
using System.Diagnostics;

namespace Ritualka.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationContext db;
        public HomeController(ILogger<HomeController> logger, ApplicationContext context)
        {
            _logger = logger;
            this.db = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Admin()
        {
            var arr_of_user_orders = db.UsersOrders.ToList();
            return View(arr_of_user_orders);
        }
        [HttpGet]
        public IActionResult Main()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Main(UserOrder user)
        {
            db.UsersOrders.Add(user);
            db.SaveChanges();
            return View();
        }
        [HttpGet]
        public IActionResult AddTovar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddTovar(AddTovar tovar) 
        {
            db.AddTovar.Add(tovar);
            db.SaveChanges();
            return View();
        }
        public IActionResult Katalog()
        {
            return View();
        }
        public IActionResult PokrivaloRitual()
        {
            var arr_of_ritual_pokirival = db.AddTovar.Where(u => u.Name == "Покрывало Ритуальное").ToList();
            return View(arr_of_ritual_pokirival);
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
            var arr_salfetki = db.AddTovar.Where(u=>u.Name == "Салфетки Пасхальные").ToList();
            return View(arr_salfetki);
        }
        public IActionResult Kitchen()
        {
            var arr_of_kitchen = db.AddTovar.Where(u => u.Name == "Занавески").ToList();
            return View(arr_of_kitchen);
        }
        public IActionResult RitualProduction2()
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