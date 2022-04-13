using MVCDEMO1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDEMO1.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello,Good Morning!!!";
        }
        public string Index1() 
        {
            return "Index 1 Method";
        }

        [HttpGet]
        public ActionResult Login()
        {
            //  ViewBag.Name = "Vhaash TECHNOLOGIES";
            //ViewBag.Action = "Login";

                 ViewData["name"] = "Vhaash Technologies";
              ViewData["action"] = "Login";

            
            TempData["username"] = "Vishal";
            TempData["usertype"] = "student";


            ViewBag.Students = new List<Student>
            {
                new Student(){RollNumber=1,Name="Sohan"},
                new Student(){RollNumber=2,Name="Rohit"},
                new Student(){RollNumber=3,Name="Prutha"}

                
                    
                
            };

            return View();
        }

        [HttpPost]
       // public ActionResult Login(string email ,string password)

        public ActionResult Login(FormCollection form)
        {
            string email = form["email"];
            string password = form["password"];

            if(!string.IsNullOrEmpty(email)
                && !string.IsNullOrEmpty(password)
                && email == "admin" && password =="admin")
            {
                return RedirectToAction("About");
            }

            ViewData["name"] = "Vhaash Technologies";
            ViewData["action"] = "Login";


            TempData["username"] = "Vishal";
            TempData["usertype"] = "student";

            ViewBag.Students = new List<Student>
            {
                new Student(){RollNumber=1,Name="Sohan"},
                new Student(){RollNumber=2,Name="Rohit"},
                new Student(){RollNumber=3,Name="Prutha"}
            };



            return View();
        }
            public ActionResult About()
        {
            // ViewBag.UserName = TempData["username"];
            // ViewBag.Usertype = TempData["usertype"];

            // TempData.Keep("username");
            // TempData.Keep("usertype");

            ViewBag.UserName = TempData.Peek("username");
            ViewBag.Usertype = TempData.Peek("usertype");

            

            return View();
        }
        public ActionResult Contact()

        {
            // ViewBag.UserName = TempData["username"];
            // ViewBag.Usertype = TempData["usertype"];

            ViewBag.UserName = TempData.Peek("username");
            ViewBag.Usertype = TempData.Peek("usertype");

            return View();
        }


        [HttpGet]
        public ActionResult Gallary()
        {
            ViewBag.UserName = TempData["username"];
            ViewBag.Usertype = TempData["usertype"];

            return View();
        }

        [HttpGet]
        [ActionName("Register")]
        public ActionResult RegisterGet()
        {
            return View();

        }

        //model as parameter
        [HttpPost]
        //   public ActionResult Register(Register register)

        [ActionName("Register")]
        public ActionResult RegisterPost()

        {

            Register register = new Register();

           //  UpdateModel<Register>(register);
            TryUpdateModel<Register>(register);

            if (ModelState.IsValid)
            {
                string email = register.Email;
                string password = register.Password;
                string ConfirmPassword = register.ConfirmPassword;

                if (password == ConfirmPassword)
                {
                    return RedirectToAction("Login");
                }
            }
            return View();

        }
    }
}