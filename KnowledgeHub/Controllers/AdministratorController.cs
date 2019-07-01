using KnowledgeHub.Models.GeneratedClassesByEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KnowledgeHub.Controllers
{
    public class AdministratorController : Controller
    {
        private KnwoledgeHubEntities db = new KnwoledgeHubEntities();
        // GET: Administrator
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RegisteredTeacherCourses()
        {
            var qry = db.TeacherRegisteredCourses.ToList();
            return View(qry);
        }

        public ActionResult RegisteredStudentCourses()
        {
            var qry = db.StudentRegisteredCourses.ToList();
            return View(qry);
        }

        public ActionResult TimeTable()
        {
            var qry = db.StudentRegisteredCourses.ToList();
            return View(qry);
        }

        public ActionResult NEWS()
        {        
            return View();
        }


        public ActionResult Announcement()
        {
           return View();
        }

        public JsonResult addNEWS(string NEWS)
        {
            NEWS oNEWS = new NEWS
            {
                News1 = NEWS,
                
            };

            db.NEWS.Add(oNEWS);
            db.SaveChanges();
            return Json("",JsonRequestBehavior.AllowGet);
        }

        public JsonResult addAnnounce(string anno)
        {
            Announcemnet oannounce = new Announcemnet
            {
                Announcement = anno,

            };

            db.Announcemnets.Add(oannounce);
            db.SaveChanges();
            return Json("", JsonRequestBehavior.AllowGet);
        }
    }
}