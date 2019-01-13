using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KnowledgeHub.Models.GeneratedClassesByEF;

namespace KnowledgeHub.Controllers
{
    public class LoginAndSignUpController : Controller
    {
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
            if (data.UserName == "kala" && data.Login_Password == "charsi")
            {
                return View();

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
    }
}