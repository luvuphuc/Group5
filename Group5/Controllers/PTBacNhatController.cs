using Antlr.Runtime.Misc;
using Group5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Group5.Controllers
{
    public class PTBacNhatController : Controller
    {
        // GET: PTBacNhat
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult UseRequest()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UseRequest(string pt = "+")
        {
            double a = double.Parse(Request["a"]);
            double b = double.Parse(Request["b"]);
            if (a == 0 && b == 0) ViewBag.KQ = "Vô số nghiệm";
            else if (a == 0) ViewBag.KQ = "Vô nghiệm";
            else ViewBag.KQ = -b / a;
            return View();
        }
        public ActionResult UseFormCollection()
        { return View(); }
        [HttpPost]
        public ActionResult UseFormCollection(FormCollection f)
        {
            double a = double.Parse(f["a"]);//Chuyển đổi chuỗi sang số thực
            double b = double.Parse(f["b"]);
            if (a == 0 && b == 0) ViewBag.KQ = "Vô số nghiệm";
            else if (a == 0) ViewBag.KQ = "Vô nghiệm";
            else ViewBag.KQ = -b / a;
            return View();
        }
        public ActionResult UseModel()
        { return View(); }
        [HttpPost]
        public ActionResult UseModel(PTBacNhat pt)
        {
            if (pt.a == 0 && pt.b == 0) ViewBag.KQ = "Vô số nghiệm";
            else if (pt.a == 0) ViewBag.KQ = "Vô nghiệm";
            else ViewBag.KQ = -pt.b / pt.a;
            return View();
        }
        
        public ActionResult UseArgu()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UseArgu(double a, double b)
        {
            if (a == 0 && b == 0) ViewBag.KQ = "Vô số nghiệm";
            else if (a == 0) ViewBag.KQ = "Vô nghiệm";
            else ViewBag.KQ = -b / a;
            return View();
        }
        
    }
}