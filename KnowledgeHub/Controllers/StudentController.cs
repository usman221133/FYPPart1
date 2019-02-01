﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KnowledgeHub.Models.GeneratedClassesByEF;
using KnowledgeHub.Models.ModelClasses;

namespace KnowledgeHub.Controllers
{
    public class StudentController : Controller
    {
        private KnwoledgeHubEntities db = new KnwoledgeHubEntities();     

        // GET: Student
        public ActionResult Index()
        {
            var User = ((List<User>)Session["UserSession"])[0];
            var res = db.Viewer_Table.Where(x => x.Viewer_Email == User.Email).ToList();

            return View(res);
        }

        [HttpGet]
        public ActionResult ViewProfile(int id)
        {
            var User = ((List<User>)Session["UserSession"])[0];
            var student = db.Viewer_Table.Where(x => x.Viewer_ID == id).FirstOrDefault();
            return View(student);
        }

        public ActionResult generator()
        {
            return View();
        }
    }
}