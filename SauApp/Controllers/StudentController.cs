using Microsoft.AspNetCore.Mvc;
using SauApp.Models;

namespace SauApp.Controllers
{
    public class StudentController : Controller
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
                ModelState.AddModelError("StudentID", "Invalid ID");
                return View("Register");
            }

            if (student.Signed == true)
            {
                ModelState.AddModelError("StudentID", "You have already signed in.");
                return View("Register");
            }

            else
            {
                student.Signed = true;
                student.SignedAt = DateTime.Now;
                ViewBag.successfully = $"{student.StudentID}{student.Name} {student.Surname} has successfully signed.";
            }
            ViewBag.Student = student;

            return View("Register");
        }
        [HttpGet]
         public IActionResult Info(string id)
        {
            var student = Repository.Students.FirstOrDefault(s => s.StudentID == id);
            if (student == null)
            {
                return RedirectToAction("Index");
            }
            return View(student);
        }




    }




}