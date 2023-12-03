using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Group5.Models;
namespace Group5.Controllers
{
    public class SubjectController : Controller
    {
        // GET: Susbject
        public string Index()
        {
            return "anhonxeo";
        }
        public ActionResult List()
        {
            var ls = new List<Subject>()
            {
                new Subject("SOT332","Hệ quản trị CSDL","3"),
                new Subject("INS333","Lập trình web","2"),
                new Subject("HAA333","Hệ điều hành", "3")
            };
            return View(ls);
        }
        public ActionResult Greeting()
        {
            ViewBag.title = "Chao ban hoc sinh";
            return View();
        }
        public ActionResult ListRender()
        {
            var ls = new List<Subject>()
            {
                new Subject("SOT332","Hệ quản trị CSDL","3"),
                new Subject("INS333","Lập trình web","2"),
                new Subject("HAA333","Hệ điều hành", "3")
            };
            return View(ls);
        }

    }
}