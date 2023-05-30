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
        public IActionResult Sharp()
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
