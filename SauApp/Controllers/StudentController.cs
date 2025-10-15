using Microsoft.AspNetCore.Mvc;
using SauApp.Models;

namespace SauApp.Controllers
{
    public class StudentController:Controller 
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

        [HttpPost]
    public ActionResult Register(Student studentSign1)
        {
            Repository.SignStudent(studentSign1);
            return View();
        }


    }
    



}