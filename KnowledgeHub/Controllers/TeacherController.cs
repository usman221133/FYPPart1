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
            return RedirectToAction("LandingPage",new {id= User.UserID });
        }

        [HttpGet]
        public ActionResult ViewProfile(int id)
        {
            var User = ((List<User>)Session["UserSession"])[0];
            var student = db.Presenter_Table.Where(x => x.Presenter_ID == id).FirstOrDefault();
            return View(student);
        }

        public ActionResult LandingPage(int id)
        {
            //var teacher = db.Presenter_Table.Where(x => x.Presenter_ID == id).FirstOrDefault();

            //for registered courses
            //var qry = db.TeacherRegisteredCourses.Where(x => x.TeacherId == teacher.Presenter_ID).ToList();
            //ViewBag.RegCourses = qry;

            return View();
        }
        public ActionResult Classroom()
        {
            //var qry = db.TeacherRegisteredCourses.Where(s => s.TeacherId == id).ToList();
            return View();
        }

    }
}