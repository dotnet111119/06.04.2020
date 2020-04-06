using MyWeb0604.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWeb0604.Controllers
{
    public class PageController : Controller
    {
        // localhost:9006/page/hello
        public ActionResult Hello()
        {
            return new FilePathResult("~/Views/Page/hello.html", "text/html");
        }

        IList<Student> studentList = new List<Student>() {
                    new Student(){ StudentID=1, StudentName="Steve", Age = 21 },
                    new Student(){ StudentID=2, StudentName="Bill", Age = 25 },
                    new Student(){ StudentID=3, StudentName="Ram", Age = 20 },
                    new Student(){ StudentID=4, StudentName="Ron", Age = 31 },
                    new Student(){ StudentID=5, StudentName="Rob", Age = 19 }
                };

        // localhost:9006/page/razordemo
        public ActionResult razordemo()
        {
            //ViewData["students"] = studentList;

            ViewBag.students = studentList; // dynamic property

            //return View("~/Views/Home/ViewPage1.cshtml");

            //return View(); // razordemo.cshtml

            return View("~/Views/Page/demo.cshtml");
        }
    }
}