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
           


            ViewBag.CoursCode = "CS101";
            ViewBag.CoursName = "Intro";
            ViewBag.CoursDate = DateTime.Today.ToShortDateString();
            ViewBag.NumberOfAccepts = Repository.Students.Count(s => s.Signed);

            return View(Repository.Students);
        }
        
    }
}
