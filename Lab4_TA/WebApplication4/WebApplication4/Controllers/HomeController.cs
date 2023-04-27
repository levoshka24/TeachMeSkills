using Azure.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApplication4.Models;
using WebApplication4.Models.EBDb2;

namespace WebApplication4.Controllers
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


       
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Index(User user)
        {
            User foundUser = await db.Users.FirstOrDefaultAsync(u => u.Email == user.Email);
            if (foundUser != null)
            {
                foundUser.DateTime = DateTime.Now;
                foundUser.Count++;
                db.Entry(foundUser).State = EntityState.Modified;
                await db.SaveChangesAsync();
            }
            else
            {
                user.DateTime = DateTime.Now;
                user.Count++;
                db.Users.Add(user);
                await db.SaveChangesAsync();
            }

            return Redirect("/Home/Privacy");
        }

        [HttpGet]
        public ActionResult Privacy()
        {
            IEnumerable<User> users = db.Users;
            ViewBag.Users = users;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About this task";
            return View();
        }
    }
}