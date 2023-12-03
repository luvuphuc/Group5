using Group5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Group5.Controllers
{
    public class StudentAvatarController : Controller
    {
        // GET: StudentAvatar
        public ActionResult StudentAvatar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult StudentAvatar(HttpPostedFileBase avatar, Student1 std)
        {
            string postedFileName = System.IO.Path.GetFileName(avatar.FileName);
            var path = Server.MapPath("/Images/" + postedFileName);
            avatar.SaveAs(path);
            string fSave = Server.MapPath("/App_Data/std.txt");
            string[] stdInfo = { std.mssv.ToString(), std.Name, std.Class, postedFileName };
            System.IO.File.WriteAllLines(fSave, stdInfo);
            ViewBag.mssv = stdInfo[0];
            ViewBag.Name = stdInfo[1];
            ViewBag.Class = stdInfo[2];
            ViewBag.Avatar = "/Images/" + stdInfo[3];
            return View("Confirm");
        }
        public ActionResult Confirm(Student1 std)
        {
            return View();
        }
    }
}