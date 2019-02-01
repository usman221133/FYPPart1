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
            var res = db.Presenter_Table.Where(x => x.Presenter_Email == User.Email).ToList();

            return View(res);
        }

        [HttpGet]
        public ActionResult ViewProfile(int id)
        {
            var User = ((List<User>)Session["UserSession"])[0];
            var student = db.Presenter_Table.Where(x => x.Presenter_ID == id).FirstOrDefault();
            return View(student);
        }
    }
}