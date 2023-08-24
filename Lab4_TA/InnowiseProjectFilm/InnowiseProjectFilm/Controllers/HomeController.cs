using InnowiseProjectFilm.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace InnowiseProjectFilm.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public ApplicationContext db;

        public HomeController(ILogger<HomeController> logger, ApplicationContext context)
        {
            _logger = logger;
            this.db = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult DelFilm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DelFilm(string name)
        {
            var us = db.Films.Where(u => u.Name == name).FirstOrDefault();
            db.Films.Remove(us);
            db.SaveChanges();
            return RedirectToAction("Films");
        }
        [HttpGet]
        public IActionResult DelQuestion()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DelQuestion(string email)
        {
            var us = db.Question.Where(u => u.Email == email).FirstOrDefault();   
            db.Question.Remove(us);
            db.SaveChanges();
            return RedirectToAction("Admin");
        }
        [HttpGet]
        public IActionResult DelComment()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DelComment(string comment)
        {
            var us = db.Commentaries.Where(u => u.Name == comment).FirstOrDefault();
            db.Commentaries.Remove(us);
            db.SaveChanges();
            return RedirectToAction("Admin");
        }
        public IActionResult Admin()
        {
            var array_of_question = db.Question.ToList();
            return View(array_of_question);
        }
       
        public IActionResult Films()
        {
            var array_of_films = db.Films.ToList();
            return View(array_of_films);
        }
        [HttpGet]
        public IActionResult AddFilm()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult AddFilm(Film newfilm)
        {
            
            db.Films.Add(newfilm);
            db.SaveChanges();
            return RedirectToAction("Films");

        }
        [HttpGet]
        public IActionResult AddComment()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddComment(Commentor comment)
        {
            db.Commentaries.Add(comment);
            db.SaveChanges();
            return RedirectToAction("Comment");
        }
        public IActionResult Comment()
        {
            var array_of_commentaries = db.Commentaries.ToList();
            return View(array_of_commentaries);
        }
        [HttpGet]
        public IActionResult MainPage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult MainPage(Question user1)
        {
            db.Question.Add(user1);
            db.SaveChanges();
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