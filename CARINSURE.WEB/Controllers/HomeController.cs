using CARINSURE.WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CARINSURE.WEB.Controllers
{
    public class HomeController : Controller
    {

      public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Authorize]
        public ActionResult MemberDetails()
        {

            return View();
        }
        public ActionResult GetRoles()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            return View(db.Roles.ToList());
        }
    }
}