using WebApplication11.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Dynamic;
using WebApplication11.Data;
using System.Reflection.Metadata;

namespace WebApplication11.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext db;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            this.db = context;
        }
       
        [HttpGet]
        public IActionResult AddComment()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddComment(Comment com)
        {
            db.Comments.Add(com);
            db.SaveChanges();
            return View();
        }

        public IActionResult Commentaries()
        {
            var comm = db.Comments.ToList();
            return View(comm);
        }

        [HttpGet]
        public IActionResult Admin()
        {
            dynamic model = new ExpandoObject();
            model.PhoneConsults = db.Phones.ToList();
            model.Courses = db.Courses.ToList();

            return View(model);
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
        
        public IActionResult IosCommentaries()
        {
            var ios_comm = db.Comments.Where(u => u.CourseName=="IOS").ToList();
            return View(ios_comm);
        }
        public IActionResult SharpCommentaries()
        {
            var ios_comm = db.Comments.Where(u => u.CourseName == "C#").ToList();
            return View(ios_comm);
        }
        public IActionResult FLutterCommentaries()
        {
            var ios_comm = db.Comments.Where(u => u.CourseName == "Flutter").ToList();
            return View(ios_comm);
        }
        public IActionResult PythonCommentaries()
        {
            var ios_comm = db.Comments.Where(u => u.CourseName == "IOS").ToList();
            return View(ios_comm);
        }
        public IActionResult EnglishCommentaries()
        {
            var ios_comm = db.Comments.Where(u => u.CourseName == "English").ToList();
            return View(ios_comm);
        }
        public IActionResult AndroidCommentaries()
        {
            var ios_comm = db.Comments.Where(u => u.CourseName == "Android").ToList();
            return View(ios_comm);
        }
        [HttpGet]
        public IActionResult AddCourse()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCourse(NewCourse crs)
        {
            db.NewCourses.Add(crs);
            db.SaveChanges();
            return View();
        }
        [HttpGet]
        public IActionResult DelCourseUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DelCourseUser(string firstname)
        {
            var us = db.Courses.FirstOrDefault(u => u.Name == firstname);
            db.Courses.Remove(us);
            db.SaveChanges();
            return RedirectToAction("Admin");
        }
        [HttpGet]
        public IActionResult DelPhoneUSer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DelPhoneUSer(string email)
        {
            var us = db.Phones.FirstOrDefault(u => u.Email==email);
            db.Phones.Remove(us);
            db.SaveChanges();
            return RedirectToAction("Admin");
        }
        [HttpGet]
        public IActionResult DelCourse()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DelCourse(string coursename)
        {
            var us = db.NewCourses.FirstOrDefault(u => u.Name == coursename);
            db.NewCourses.Remove(us);
            db.SaveChanges();
            return RedirectToAction("Admin");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}