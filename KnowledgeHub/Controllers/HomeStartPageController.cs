using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KnowledgeHub.Controllers
{
    public class HomeStartPageController : Controller
    {
        // GET: HomeStartPage
        public ActionResult Index()
        {
            return View();
        }
    }
}