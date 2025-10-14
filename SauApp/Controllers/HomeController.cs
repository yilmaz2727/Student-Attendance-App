using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SauApp.Models;

namespace SauApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var students = Repository.GetGuests();


            ViewBag.CoursCode = "CS101";
            ViewBag.CoursName = "Intro";
            ViewBag.CoursDate = DateTime.Today.ToShortDateString();
            ViewBag.NumberOfAccepts = students.Count(s => s.Signed);

            return View(students); // kritik: modeli View'a gönder
        }
    }
}
