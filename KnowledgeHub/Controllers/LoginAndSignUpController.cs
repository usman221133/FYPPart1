using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KnowledgeHub.Models.GeneratedClassesByEF;
using KnowledgeHub.Models;
using KnowledgeHub.Models.ModelClasses;

namespace KnowledgeHub.Controllers
{
    public class LoginAndSignUpController : Controller
    {
        private KnwoledgeHubEntities db = new KnwoledgeHubEntities();
        // GET: LoginAndSignUp
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult LoginUser()
        {

            return View();
        }

        [HttpPost]
        public ActionResult LoginUser(Login_Table data)
        {
            var res = (from a in db.Users
                      where a.Email == data.UserName && a.Password == data.Login_Password
                      select a).ToList();
            if (res.Count>0)
            {
                if (res[0].Role =="Student")
                {
                    if (data.UserName == res[0].Email && data.Login_Password == res[0].Password)
                    {
                        return View();

                    }
                    else
                    {
                        return View();

                    }
                }
                else if (res[0].Role =="Teacher")
                {
                    if (data.UserName == res[0].Email && data.Login_Password == res[0].Password)
                    {
                        return View();

                    }
                    else
                    {
                        return View();

                    }
                }
                else
                {
                    return View();
                }
               
            }
            else
            {
                return View();
            }
            
        }


        public ActionResult SignUpUser()
        {

            return View();
        }

        [HttpPost]
        public ActionResult SignUpUser(PresenterViewerModel data)

        {
            if (data.LoginAs =="Student")
            {
                Viewer_Table oVT = new Viewer_Table
                {
                    Viewer_Name = data.Presenter_Name,
                    Viewer_Ph_Num = data.Presenter_Ph_Num,
                    Viewer_Email = data.Presenter_Email,
                    Password = data.Password,
                    ConfirmPassword = data.ConfirmPassword,
                    DOB_Days = data.DOB_Days,
                    DOB_Months = data.DOB_Months,
                    DOB_Year = data.DOB_Year,
                    Viewer_Gender = data.Presenter_Gender,
                    Viewer_City = data.Presenter_City
                };
                db.Viewer_Table.Add(oVT);
                db.SaveChanges();

                User oUser = new User
                {
                    Name =data.Presenter_Name,
                    PhoneNumber =data.Presenter_Ph_Num,
                    City =data.Presenter_City,
                    Email =data.Presenter_Email,
                    Password = data.Password,
                    ConfirmPassword = data.ConfirmPassword,
                    Gender =data.Presenter_Gender,
                    Role = "Student"
                  
                };
                db.Users.Add(oUser);
                db.SaveChanges();
            }
            else
            {
                Presenter_Table oPT = new Presenter_Table
                {
                    Presenter_Name = data.Presenter_Name,
                    Presenter_Ph_Num = data.Presenter_Ph_Num,
                    Presenter_Email = data.Presenter_Email,
                    Password = data.Password,
                    ConfirmPassword = data.ConfirmPassword,
                    DOB_Days = data.DOB_Days,
                    DOB_Months = data.DOB_Months,
                    DOB_Year = data.DOB_Year,
                    Presenter_Gender = data.Presenter_Gender,
                    Presenter_City = data.Presenter_City

                };
                db.Presenter_Table.Add(oPT);
                db.SaveChanges();

                User oUser = new User
                {
                    Name = data.Presenter_Name,
                    PhoneNumber = data.Presenter_Ph_Num,
                    City = data.Presenter_City,
                    Email = data.Presenter_Email,
                    Password = data.Password,
                    ConfirmPassword = data.ConfirmPassword,
                    Gender = data.Presenter_Gender,
                    Role = "Teacher"

                };
                db.Users.Add(oUser);
                db.SaveChanges();
            }
          
            return View();
        }
    }
}