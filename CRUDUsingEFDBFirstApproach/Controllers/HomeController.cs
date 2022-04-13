using CRUDUsingEFDBFirstApproach.Common;
using CRUDUsingEFDBFirstApproach.Models;
using System.Linq;
using System.Web.Mvc;

namespace CRUDUsingEFDBFirstApproach.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
      //  [CustomFilterAttribute]
        public ActionResult Post()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
      //  [CustomFilterAttribute]
        //   [HandleError]
        public ContentResult Post(string post)
        {
            // ViewBag.Post = post;
            //  return View();
            
       //     int a = 10, b = 0;
         //   int c = a / b;

            return Content(post, "text/html");
        }

        // GET: Home
        public ViewResult Index()
        {
            return View();
        }
     
        //public void Method1()

        public EmptyResult Method1()
        {
            Response.Write("Method 1 called <br/>");

            return new EmptyResult();
        }

        // public string Method2()
        public ContentResult Method2()

        {
            return Content("Good Morning!!!");
        }

        public ContentResult Method3()

        {
            return Content("<h1>Good Morning</h1>Name:<input type='text'/><input type='button' value='Submit'/>", "text/html");
        }

        //try tocall it using ajax
        public JavaScriptResult Method4()

        {
            return JavaScript("alert('Hello from MVC action method')");
        }


        // public HttpNotFoundResult Method5(int? id)
        public ActionResult Method5(int? id)

        {
            if (id <= 0)
            {
                return new HttpNotFoundResult();
            }
            else
            {
                return RedirectToAction("Index");

            }
        }
          
          


        //  [HttpGet]
        [AcceptVerbs(HttpVerbs.Get)]
        public ViewResult Welcome(int? id,string name)
        {
           ViewBag.Id = id;
            ViewBag.Name = name;
            return View();
        }

        //private ActionResult Hello()

        [NonAction]
        public ViewResult Hello()

        {
            return View();

        }

        public PartialViewResult MyPartialView1()
        {

            string msg = "Data for partial view";

            return PartialView("MyPartialView1", msg);
        }
       public PartialViewResult  TrainersList()
        {
            InstituteDBContext db = new InstituteDBContext();

            return PartialView("TrainerListPartialView", db.Trainers.ToList());
        }     
    }
}