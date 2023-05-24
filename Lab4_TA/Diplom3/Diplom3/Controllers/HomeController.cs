using Diplom3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Diplom3.Controllers
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
        [HttpGet]
        public IActionResult Log_in()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Log_in(string email,string password)
        {
            if (ModelState.IsValid)
            {
                var data = db.UserLogIns.Where(s => s.Email.Equals(email) && s.Password.Equals(password)).ToList();
                if (data.Count() > 0)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.error = "Login failed";
                    return RedirectToAction("Login");
                }
                return View();
            }
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Tutor()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Course_main()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Course_main(PhoneConsult phone)
        {
            db.Phones.Add(phone);
            db.SaveChanges();
            return View();
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}