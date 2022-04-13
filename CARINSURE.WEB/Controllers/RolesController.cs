using CARINSURE.WEB.BusinessLayer;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CARINSURE.WEB.Controllers
{
    [Authorize(Roles ="super admin")]
    public class RolesController : Controller
    {
        // GET: Roles
        public ActionResult Index()
        {
            RolesBL bl = new RolesBL();
            return View(bl.GetRoles());

        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create( IdentityRole identityRole)
        {
            if (ModelState.IsValid)
            {
                RolesBL bl = new RolesBL();
                if (bl.Insert(identityRole))
                {
                    return RedirectToAction("Index", "Roles");
                }
            }
            return View();
        }
    }
}