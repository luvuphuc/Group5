using Group5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Group5.Controllers
{
    public class RazorPTBacNhatController : Controller
    {
        // GET: RazorPTBacNhat
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(PTBacNhat pt)
        {
            return View();
        }
    }
}