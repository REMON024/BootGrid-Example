using BootGrid_Example.Models;
using BootGrid_Example.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootGrid_Example.Controllers
{
    public class HomeController : Controller
    {
        StudentService student;
        public HomeController()
        {
            student = new StudentService();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetStudent()
        {
            List<Student> students = new List<Student>();

            return View(students);

        }

        public ActionResult GetStudents()
        {
            //var request= HttpContext.Request["rowCount"];
            var current = Convert.ToInt32(HttpContext.Request.Form["current"]);
            var searchPhrase = HttpContext.Request.Form["searchPhrase"];
            var rowCount = Convert.ToInt32(HttpContext.Request.Form["rowCount"]);
            var students = student.GetStudent();
            var result = new DataFormate()
            {
                current = current,
                searchPhrase = searchPhrase,
                rowCount = rowCount,
                total = students.Count,
                rows=students.Skip(rowCount * (current-1)).Take(rowCount).ToList()
            };
            return Json(result);
            //return View(students);

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}