using Microsoft.AspNetCore.Mvc;
using SauApp.Models;

namespace SauApp.Controllers
{
    public class StudentController:Controller 
    {
        public ActionResult Index()
        {
            var student = Repository.Students;
            return View(student);
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(string studentId)
        {
            var student = Repository.Students.FirstOrDefault(s => s.StudentID == studentId);

            if (student == null)
            {
                return RedirectToAction("Register");
            }
            if(!student.Signed)
            {
                student.Signed = true;
                student.SignedAt = DateTime.Now;
                return View("FeedBack", student);// !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            }
            else
            {
                ViewBag.ErrorMessage = "You have Already Sign!";
                return View();
            }
        }
      
    

    }
    

    

}