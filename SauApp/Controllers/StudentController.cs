using Microsoft.AspNetCore.Mvc;
using SauApp.Models;

namespace SauApp.Controllers
{
    public class Student : Controller
    {
        public ActionResult Index()
        {
            return View(Repository.GetGuests());
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
    


    }
    



}