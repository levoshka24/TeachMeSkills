using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using System.Net.Cache;
using WebApplication3.Models;

using WebApplication3.Models.TMS_HW;

namespace WebApplication3.Controllers
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

       

        // добавление в бд
        public IActionResult Create()
        {
            var authors = db.Authors.ToList();
            IEnumerable<SelectListItem> authorItems =authors.Select(m => new SelectListItem
            {
                Value = m.Id.ToString(),
                Text = m.Name
            });
            ViewBag.Author = authorItems;
            

            return View();

        }
        // сохранение в бд новых данных
        //[HttpPost]
        //public  IActionResult Create(UserViewModel model)
        //{
        //    var authors = db.Authors.FirstOrDefault(m => m.Id == model.AuthorId);
        //    var book = new Book
        //    {
        //        Name = model.Name,
        //        CountOfPages = model.Count
        //        AuthorId = authors,

        //    };

        //    db.Books.Add(book);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");

        //}

    
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Privacy()
        {
            var users = db.Books.ToList();
            return View(users);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}