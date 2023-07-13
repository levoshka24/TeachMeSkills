using Diplom3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Diplom3.Controllers
{
    public class CourseController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationContext db;
        public CourseController(ILogger<HomeController> logger, ApplicationContext context)
        {
            _logger = logger;
            this.db = context;
        }

        public IActionResult Course_offline()
        {
            return View();
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
            return View();
        }
        public IActionResult All_courses()
        {
            return View();
        }
        
    }
}
