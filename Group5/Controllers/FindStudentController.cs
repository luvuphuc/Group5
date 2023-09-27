using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Group5.Models;
namespace Group5.Controllers
{
    public class FindStudentController : Controller
    {
        // GET: FindStudent
        public string Index()
        {
            return "Find";
        }
        public ActionResult List(int id)
        {
            var ls = new List<College>()
            {
                new College(321,"Lữ Vũ Phúc","63cntt4","sot321"),
                new College(123,"Lê Minh Thành","63cntt4","sot321"),
                new College(213,"Trần Duy Phát","63cntt1","INS231")
            };
            foreach(College c in ls)
            {
                if (id == c.mssv)
                {
                    return Content(id + " " + c.Name + " " + c.Class);  
                }
            }
            return Content("Khong co");
        }
        public ActionResult Find(int id)
        {
            var ls = new List<College>()
            {
                new College(321,"Lữ Vũ Phúc","63cntt4","sot321"),
                new College(123,"Lê Minh Thành","63cntt4","sot321"),
                new College(213,"Trần Duy Phát","63cntt1","INS231")
            };
            foreach (College c in ls)
            {
                if (id == c.mssv)
                {
                    ViewBag.Data = c;
                    return View();
                }
            }
            return Content("Khong co");
        }
        public ActionResult ListViewBag()
        {
            var ls = new List<College>()
            {
                new College(321,"Lữ Vũ Phúc","63cntt4","sot321"),
                new College(123,"Lê Minh Thành","63cntt4","sot321"),
                new College(213,"Trần Duy Phát","63cntt1","INS231"),
                new College(233,"Trần Cao Lam","63cntt1","INS211")
            };
            ViewBag.list = ls;
            var filter = ls.Where(m => m.Class == "63cntt4").ToList();
            ViewBag.filter = filter;
            return View();
        }
        public ActionResult ListModel()
        {
            var ls = new List<College>()
            {
                new College(321,"Lữ Vũ Phúc","63cntt4","sot321"),
                new College(123,"Lê Minh Thành","63cntt4","sot321"),
                new College(213,"Trần Duy Phát","63cntt1","INS231"),
                new College(233,"Trần Cao Lam","63cntt1","INS211"),
                new College(312,"Duy Đan","63cntt4","SOT211")
            };
            var filt = new List<College>();

            foreach(var c in ls) { 
                if (c.Class == "63cntt4")
                {
                    filt.Add(c);
                }
            }
            var viewCollege = new ViewCollege()
            {
                listCollege = ls,
                filtCollege = filt
            };
            return View(viewCollege);
        }
    }
}