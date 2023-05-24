using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication5.Models;
using WebApplication5.Models.EFDb7;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public ApplicationContext db;

        public HomeController(ILogger<HomeController> logger,ApplicationContext context)
        {
            _logger = logger;
            this.db = context;
        }
        [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Index()
        {
            var users = db.Users.ToList();
            return View(users);
        }
        
        [HttpPost]
        public IActionResult Privacy(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
            return RedirectToAction("Index");   
           
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}