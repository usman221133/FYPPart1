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
            //var res = db.Viewer_Table.Where(x => x.Viewer_Email == User.Email).ToList();

            //return View(res);
            return RedirectToAction("LadingPage", new { viewerid = User.UserID });
        }

        [HttpGet]
        public ActionResult ViewProfile(int id)
        {
            //var User = ((List<User>)Session["UserSession"])[0];
            var student = db.Viewer_Table.Where(x => x.Viewer_ID == id).FirstOrDefault();
            return View(student);
        }

        public ActionResult generator()
        {
            return View();
        }

        public ActionResult LadingPage(int viewerid)
        {
            //var user = db.Viewer_Table.Where(x => x.Viewer_Email == email).FirstOrDefault();
            var student = db.Viewer_Table.Where(x => x.Viewer_ID == viewerid).FirstOrDefault();

            //for registered courses
            var qry = db.StudentRegisteredCourses.Where(x => x.viewer_id == student.Viewer_ID).ToList();
            ViewBag.RegCourses = qry;

            return View(student);
        }

        public ActionResult TeacherRegisterCourse(int id)
        {
            //var user = db.Viewer_Table.Where(x => x.Viewer_Email == email).FirstOrDefault();
            //var student = db.Viewer_Table.Where(x => x.Viewer_ID == id).FirstOrDefault();

            //for registered courses
            var qry = db.TeacherRegisteredCourses.ToList();
            ViewBag.Viewer_id = id;

            return View(qry);
        }

        public ActionResult TimeTable(int id)
        {
            var qry = db.StudentRegisteredCourses.Where(s=>s.viewer_id == id).ToList();
            ViewBag.Viewer_id = id;

            return View(qry);
        }

        public ActionResult Classroom(int id)
        {
            var qry = db.StudentRegisteredCourses.Where(s=>s.viewer_id == id).ToList();
            return View(qry);
        }




        public JsonResult InsertStudentRegisteredCourses(List<TeacherRegisteredCours> data)
        {
            
            var User = ((List<User>)Session["UserSession"])[0];
            if (data.Count > 0)
            {
                for (int i = 0; i < data.Count; i++)
                {
                    StudentRegisteredCours oSRC = new StudentRegisteredCours
                    {
                        viewer_coursename = data[i].CourseName,
                        teacher_id =Convert.ToInt32(data[i].TeacherId),
                        teacher_name = data[i].TeacherName,
                        viewer_courseid = data[i].id,
                        viewer_id =User.UserID,
                        timing = data[i].Timing,
                        days = data[i].Days
                    };
                    db.StudentRegisteredCourses.Add(oSRC);
                    db.SaveChanges();
                }
                return Json("Success", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("SelectOne", JsonRequestBehavior.AllowGet);
            }
        }
    }
}