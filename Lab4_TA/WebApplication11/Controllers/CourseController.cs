using WebApplication11.Models;
using Microsoft.AspNetCore.Mvc;
using WebApplication11.Data;

namespace WebApplication11.Controllers
{
    public class CourseController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext db;
        public CourseController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            this.db = context;
        }

        public IActionResult Course_offline()
        {
            var courses = db.NewCourses.ToList();
            return View(courses);
        }
        public IActionResult Flutter()
        {
            return View();
        }
        public IActionResult Sharp()
        {
            return View();
        }
        public IActionResult IOS()
        {
            return View();
        }
        [HttpGet]
        public IActionResult SelectCourse()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SelectCourse(Course course)
        {
            db.Courses.Add(course);
            db.SaveChanges();
            return View();
        }
        public IActionResult Android()
        {
            return View();
        }
        public IActionResult Proforientation()
        {
            return View();
        }
        public IActionResult Python()
        {
            return View();
        }
        public IActionResult English()
        {
            return View();
        }
        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult Course_online()
        {
            var courses = db.NewCourses.ToList();
            db.SaveChanges();
            return View(courses);
        }
        public IActionResult All_courses()
        {
            return View();
        }
        [HttpGet]
        public IActionResult DeleteComment()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DeleteComment(string firstname)
        {
            var us2 = db.Comments.FirstOrDefault(u => u.Name == firstname);
            db.Comments.Remove(us2);
            db.SaveChanges();
            return View();
        }
    }
}
