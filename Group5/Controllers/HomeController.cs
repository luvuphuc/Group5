using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using Group5.Models;
namespace Group5.Controllers
{
    public class HomeController : Controller
    {
        public string Index(string id)
        {
            return "Chao cac ban " + id;
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
        public ActionResult Greeting()
        {
            ViewBag.title = "Chao cac ban";
            return View();
        }
        public ActionResult List()
        {
            var ls = new List<Student>()
            {
                new Student("LMT","63cntt4"),
                new Student("LVP","63cntt4"),
                new Student("TDP","63cntt4")
            };
            return View(ls);
        }
        public ActionResult Manage() 
        {
            return RedirectToAction("Index","Home");
        }
    }
}