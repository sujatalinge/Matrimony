using CRUDUsingEFDBFirstApproach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUDUsingEFDBFirstApproach.Controllers
{
    //[RoutePrefix("vhaash/account")]
    public class AccountController : Controller
    {
        [HttpGet]
      //  [Route("newstudent")]
        public ViewResult Register()
        {
            return View();
        }
        [HttpPost]
      //  [Route("newstudent")]
        public ActionResult Register(Register register)
        {
            //   if (string.IsNullOrEmpty(register.ConfirmPassword))
            //  {
            //    ModelState.AddModelError("ConfirmPassword", "please enter confirm password");
            // }

       //     InstituteDBContext db = new InstituteDBContext();
         //   bool isExists = db.Registers.
          //       Any(r => r.UserName.
          //       Equals(register.UserName, StringComparison.OrdinalIgnoreCase));

          //  if (isExists)
           // {
             //   ModelState.AddModelError("UserName","Username is already taken");
        //    }


            if (ModelState.IsValid)
            {
                InstituteDBContext db = new InstituteDBContext();
                db.Registers.Add(register);
                db.SaveChanges();

                return RedirectToAction("Index","Trainers");
            }
            return View();
        }

       // [Route("IsUserNameExists")]
          public JsonResult IsUserNameExists(string UserName)
        {
            InstituteDBContext db = new InstituteDBContext();
           bool isExists= db.Registers.
                Any(r => r.UserName.
                Equals(UserName, StringComparison.OrdinalIgnoreCase));

            return Json(!isExists, JsonRequestBehavior.AllowGet);
        }
    }
}