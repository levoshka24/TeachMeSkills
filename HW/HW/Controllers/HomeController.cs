using HW.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;
using System.Xml.Linq;

namespace HW.Controllers
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
        [HttpGet]
        public IActionResult Form()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Form(string username, string password)
        {
            string userName = "s1mple";
            string passwordp = "sasha";
            
            if (username.Equals(userName)&& password.Equals(passwordp))
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return StatusCode(404);
            }
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