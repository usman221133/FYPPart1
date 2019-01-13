using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KnowledgeHub.Controllers
{
    public class LoginAndSignUpController : Controller
    {
        // GET: LoginAndSignUp
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LoginUser()
        {

            return View();
        }


        public ActionResult SignUpUser()
        {

            return View();
        }
    }
}