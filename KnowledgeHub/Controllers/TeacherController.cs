using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KnowledgeHub.Models.GeneratedClassesByEF;

namespace KnowledgeHub.Controllers
{
    public class TeacherController : Controller
    {
        private KnwoledgeHubEntities db = new KnwoledgeHubEntities();
        // GET: Teacher
        public ActionResult Index()
        {
            var User = ((List<User>)Session["UserSession"])[0];
            //var res = db.Presenter_Table.Where(x => x.Presenter_Email == User.Email).ToList();

            //return View(res);
            return RedirectToAction("LandingPage",new {userid= User.UserID });
        }

        [HttpGet]
        public ActionResult ViewProfile(int id)
        {
           // var User = ((List<User>)Session["UserSession"])[0];
            var student = db.Presenter_Table.Where(x => x.Presenter_ID == id).FirstOrDefault();
            return View(student);
        }

        public ActionResult LandingPage(int userid)
        {
           
            var teacher = db.Presenter_Table.Where(x => x.UserID == userid).FirstOrDefault();

            //for registered courses
            var qry = db.TeacherRegisteredCourses.Where(x => x.TeacherId == teacher.Presenter_ID).ToList();
            ViewBag.RegCourses = qry;

            return View(teacher);
        }

        public ActionResult TeacherRegisterCourse(int id)
        {
            //var user = db.Viewer_Table.Where(x => x.Viewer_Email == email).FirstOrDefault();
            var teacher = db.Presenter_Table.Where(x => x.Presenter_ID == id).FirstOrDefault();

            //for registered courses
            var qry = db.TeacherRegisteredCourses.Where(s=>s.TeacherId==teacher.Presenter_ID).ToList();
            ViewBag.presenterID = id;
            ViewBag.UserID = teacher.UserID;

            return View(qry);
        }

        public ActionResult TimeTable(int id)
        {
            var qry = db.TeacherRegisteredCourses.Where(s => s.TeacherId == id).ToList();
            ViewBag.presenterID = id;

            var teacher = db.Presenter_Table.Where(x => x.Presenter_ID == id).FirstOrDefault();
            ViewBag.UserID = teacher.UserID;

            return View(qry);
        }

        public ActionResult Classroom(int id)
        {
            var qry = db.TeacherRegisteredCourses.Where(s => s.TeacherId == id).ToList();

            var teacher = db.Presenter_Table.Where(x => x.Presenter_ID == id).FirstOrDefault();
            ViewBag.UserID = teacher.UserID;
            return View(qry);
        }

        public JsonResult InsertCourse(string courseName, string DDLDays, string DDLTimings, int teacherId)
        {
            var qry = db.Presenter_Table.Where(f=>f.Presenter_ID == teacherId).FirstOrDefault();
            TeacherRegisteredCours oTRC = new TeacherRegisteredCours
            {
                CourseName =courseName,
                TeacherId = teacherId,
                TeacherName = qry.Presenter_Name,
                Timing = DDLTimings,
                Days=DDLDays
            };

            db.TeacherRegisteredCourses.Add(oTRC);
            db.SaveChanges();
            return Json("",JsonRequestBehavior.AllowGet);
        }

    }
}