using Group5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Group5.Controllers
{
    public class HelperCalculationController : Controller
    {
        // GET: HelperCalculation
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(double a, double b)
        {
            if (a == 0 && b == 0) ViewBag.KQ = "Vô số nghiệm";
            else if (a == 0) ViewBag.KQ = "Vô nghiệm";
            else ViewBag.KQ = -b / a;
            return View();
        }
    }
}