﻿using Diplom3.Models;
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
        public IActionResult Log_in(UserLogIn user)
        {
                string admin = "admin";
                string password = "admin";
                var data = db.UserLogIns.Where(s => s.Email.Equals(user.Email) && s.Password.Equals(user.Password)).ToList();
                var data2 = db.UserLogIns.Where(s => s.Email.Equals(admin) && s.Password.Equals(password)).ToList();
                if (data2.Count > 0)
                {
                    return RedirectToAction("Admin");

                }
                if (data.Count > 0)
                {
                    return RedirectToAction("Tutor");
                }
                else
                {
                    return RedirectToAction("Index");
                }
                
                
                
            
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Admin()
        {
            var phones_consult = db.Phones.ToList();
            return View(phones_consult);
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
        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registration(UserLogIn user)
        {
            db.UserLogIns.Add(user);
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