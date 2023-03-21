using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class ExampController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
