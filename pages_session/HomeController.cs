using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWeb0604.Controllers
{
    public class HomeController : Controller
    {


        // localhost:9006/home/index
        public ActionResult Index()
        {

            //return Content("Hello world!");

            //return Redirect("https://www.ynet.co.il/home/0,7340,L-8,00.html");

            return new FilePathResult("~/Views/Home/loging.html", "text/html");
        }

        // localhost:9006/home/data
        public ActionResult data()
        {

            //return Content("Hello world!");

            //return Redirect("https://www.ynet.co.il/home/0,7340,L-8,00.html");

            return new FilePathResult("~/Views/Home/data.html", "text/html");
        }

        public ActionResult DataProcess()
        {
            string item = Request.Params["itemtxt"];
            //Session["item"] = item;
            HttpContext.Application["item"] = item;

            return Content($"{item} recieved!");
        }

        public ActionResult Whatsmydata()
        {

            return Content($"data =  {HttpContext.Application["item"]}");
        }

        public ActionResult LoginProcess()
        {
            string name = Request.Params["nametxt"];
            Session["username"] = name;

            return Content($"Hello {name}");
        }

        public ActionResult Whatsmyname()
        {

            return Content($"Hello {Session["username"]}");
        }
    }
}
