using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CRUDUsingEFDBFirstApproach.Models;
using System.Threading;
using CRUDUsingEFDBFirstApproach.Common;

namespace CRUDUsingEFDBFirstApproach.Areas.student.Controllers
{
    [Authorize]
     public class StudentsController : Controller
    {
        private InstituteDBContext db = new InstituteDBContext();

        // GET: student/Students
        [AllowAnonymous]
       // [OutputCache(Duration =60, VaryByParam ="None")]
       [OutputCache(CacheProfile = "60SecondCache")]
 //  [RequireHttps]
      public ActionResult Index()
        {
            Thread.Sleep(5000);
            return View();
         //   var students = db.Students.Include(s => s.Trainer);
           // return View(students.ToList());
        }

        [AllowAnonymous]
         [ChildActionOnly]
        //  [OutputCache(Duration = 60, VaryByParam = "None")]
        //  [OutputCache(CacheProfile = "60SecondCache")]
         [CustomOutputCache("60SecondCache")]
        public PartialViewResult AllStudents()
        {
            Thread.Sleep(5000);
            var students = db.Students.Include(s => s.Trainer);
            // return PartialView("_Students",students.ToList());

            return PartialView("~/Areas/student/Views/Shared/_Students.cshtml", students.ToList());

        }

        [AllowAnonymous]

          [ChildActionOnly]
        //  [OutputCache(Duration = 60, VaryByParam = "None")]
        // [OutputCache(CacheProfile = "60SecondCache")]
        [CustomOutputCache("60SecondCache")]
        public PartialViewResult FirstTwoStudents()
        {
            Thread.Sleep(5000);

            var students = db.Students.OrderByDescending(s =>s.Name)
                .Take(2)
                .Include(s => s.Trainer);
            return PartialView("_Students", students.ToList());
        }
       
        
        [AllowAnonymous]
          [ChildActionOnly]
        //   [OutputCache(Duration = 60, VaryByParam = "None")]
        [OutputCache(CacheProfile = "60SecondCache")]
        [CustomOutputCache("60SecondCache")]
        public PartialViewResult LastTwoStudents()
        {
            Thread.Sleep(5000);

            var students = db.Students
                .OrderBy(s => s.Name)
                .Take(2)
                .Include(s => s.Trainer);
            return PartialView("_Students", students.ToList());
        }


        // GET: student/Students/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // GET: student/Students/Create
        public ActionResult Create()
        {
            ViewBag.Trainerid = new SelectList(db.Trainers, "Id", "Name");
            return View();
        }

        // POST: student/Students/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RollNumber,Name,Gender,Trainerid")] Student student)
        {
            if (ModelState.IsValid)
            {
                db.Students.Add(student);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Trainerid = new SelectList(db.Trainers, "Id", "Name", student.Trainerid);
            return View(student);
        }

        // GET: student/Students/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            ViewBag.Trainerid = new SelectList(db.Trainers, "Id", "Name", student.Trainerid);
            return View(student);
        }

        // POST: student/Students/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RollNumber,Name,Gender,Trainerid")] Student student)
        {
            if (ModelState.IsValid)
            {
                db.Entry(student).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Trainerid = new SelectList(db.Trainers, "Id", "Name", student.Trainerid);
            return View(student);
        }

        // GET: student/Students/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: student/Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Student student = db.Students.Find(id);
            db.Students.Remove(student);
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
