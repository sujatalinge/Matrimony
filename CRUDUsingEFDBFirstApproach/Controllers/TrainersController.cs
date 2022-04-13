
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using CRUDUsingEFDBFirstApproach.Models;
using PagedList;
using PagedList.Mvc;

namespace CRUDUsingEFDBFirstApproach.Controllers
{
  //  [RoutePrefix("vtrainers")]
    public class TrainersController : Controller
    {
        private InstituteDBContext db = new InstituteDBContext();

        [HttpGet]
        // GET: Trainer
       // [RequireHttps]
   //    [OutputCache(Duration = 10)]
        public ActionResult Index(string search, int? page, string sortBy)
        {
            Thread.Sleep(5000);

            var trainers = db.Trainers.ToList();

            if (!string.IsNullOrEmpty(search))
            {
                //logic --equal /startswith/ contains
                // trainers=   trainers.
                //Where(t => t.Name.ToUpper().Equals(search.ToUpper())).ToList();

                trainers = trainers.
                Where(t =>
                t.Name.ToUpper().Contains(search.ToUpper()) ||
                t.Salary.ToString().Equals(search)
                ).ToList();

            }

            #region sort by name


            sortBy = string.IsNullOrEmpty(sortBy) ? "name asc " : sortBy;

            ViewBag.NameSort = sortBy == "name asc" ? "name asc" : "name desc";

            ViewBag.SalarySort = sortBy == "salary desc" ? "salary desc" : "salary asc";


            switch (sortBy)
            {
                case "name asc":
                    trainers = trainers.OrderBy(t => t.Name).ToList();
                    ViewBag.NameSort = "name desc";
                    break;
                case "name desc":
                    trainers = trainers.OrderByDescending(t => t.Name).ToList();
                    ViewBag.NameSort = "name asc";
                    break;

                case "salary asc":
                    trainers = trainers.OrderBy(t => t.Salary).ToList();
                    ViewBag.SalarySort = "salary desc";
                    break;
                case "salary desc":
                    trainers = trainers.OrderByDescending(t => t.Salary).ToList();
                    ViewBag.SalarySort = "salary asc";
                    break;

                default:
                    trainers = trainers.OrderBy(t => t.Name).ToList();
                    ViewBag.NameSort = "name desc";

                    break;
            }
            // ViewBag.SortBy = sortBy;

            //    ViewBag.SortBy = string.IsNullOrEmpty(ViewBag.SortBy) 
            //      ? "name asc" : "name desc";


            //  if (sortBy.Equals("name asc"))
            //{
            //  trainers = trainers.OrderBy(t => t.Name).ToList();
            //  ViewBag.SortBy = "name desc";

            //  }
            //else
            // {
            //   trainers = trainers.OrderByDescending(t => t.Name).ToList();
            // ViewBag.SortBy = "name asc";

            //            }
            #endregion sort by name

            #region Commented code
            // sortBySalary = string.IsNullOrEmpty(sortBySalary) ?
            //   "salary asc" : sortBySalary;

            //  ViewBag.SortBySalary = string.IsNullOrEmpty(ViewBag.SortBySalary)
            //    ? "salary asc" : "salary desc";


            //if (ViewBag.SortBySalary.Equals("salary asc"))
            // {
            //   trainers = trainers.OrderBy(t => t.Salary).ToList();
            // ViewBag.SortBySalary = "name desc";

            // }
            //  else
            //{
            //  trainers = trainers.OrderByDescending(t => t.Salary).ToList();
            //ViewBag.SortBySalary = "Salary asc";

            //  }
            #endregion commented code
            return View(trainers.ToPagedList(page ?? 1, 6));
        }

        // GET: Trainers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trainer trainer = db.Trainers.Find(id);
            if (trainer == null)
            {
                return HttpNotFound();
            }
            return View(trainer);
        }

        [HttpGet]
        public ActionResult CreateMultiple()
        {

            return View();
        }

        [HttpPost]
        public ActionResult CreateMultiple(Trainer trainer, string actionName)
        {
            if (ModelState.IsValid)
            {
                if (actionName.Equals("Save & Close"))
                {
                    db.Trainers.Add(trainer);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                else if (actionName.Equals("Save & Continue"))
                {
                    if (ModelState.IsValid)
                    {
                        db.Trainers.Add(trainer);
                        db.SaveChanges();

                        ViewBag.Message = "Trainer created successfully";

                        return View(new Trainer());
                    }

                }
            }

            return View(trainer);
        }

        [HttpGet]
        public ActionResult CreateMultipleOneScreen()
        {


            return View();
        }

        [HttpPost]
        [ActionName("CreateMultipleOneScreen")]
        public ActionResult CreateMultipleOneScreenPost(IEnumerable<Trainer> trainers)
        //  (IEnumerable<Trainer> trainers)
        {
           
            if (trainers != null && trainers.Count() > 0)
            {
                foreach (var t in trainers)
                {
                    db.Trainers.Add(t);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");

            }
         
    
            return View();
        }
        [HttpGet]
        public PartialViewResult CreateTrainerView()
        {
            return PartialView("_CreateTrainerView");
        }
        
        




        [HttpPost]
        public ActionResult CreateMultipleContinue(Trainer trainer)
        {
            if (ModelState.IsValid)
            {
                db.Trainers.Add(trainer);
                db.SaveChanges();
                // return RedirectToAction("Index");
                return View("CreateMultiple");
            }

            return View(trainer);
        }


        [HttpGet]
        [Route("generate")]
      //   [Authorize]
        // GET: Trainers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Trainers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
      
        [HttpPost]
        [ValidateAntiForgeryToken]
     //   [Route("generate")]

        public ActionResult Create([Bind(Include = "Id,Name,Salary")] Trainer trainer)
        {
            if (ModelState.IsValid)
            {
                db.Trainers.Add(trainer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(trainer);
        }

        // GET: Trainers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trainer trainer = db.Trainers.Find(id);
            if (trainer == null)
            {
                return HttpNotFound();
            }
            return View(trainer);
        }

        // POST: Trainers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Salary")] Trainer trainer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(trainer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(trainer);
        }

        // GET: Trainers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trainer trainer = db.Trainers.Find(id);
            if (trainer == null)
            {
                return HttpNotFound();
            }
            return View(trainer);
        }

        [HttpPost]
        public ActionResult DeleteMultiple(IEnumerable<string> checkTrainer)
        {
            if(checkTrainer !=null && checkTrainer.Count() > 0)
            {
                foreach(var id in checkTrainer)
                {
                    Trainer trainer = db.Trainers.Find(int.Parse(id));
                    db.Trainers.Remove(trainer);
                    db.SaveChanges();

                }
            }

            return RedirectToAction("Index");
        }


        // POST: Trainers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Trainer trainer = db.Trainers.Find(id);
            db.Trainers.Remove(trainer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
