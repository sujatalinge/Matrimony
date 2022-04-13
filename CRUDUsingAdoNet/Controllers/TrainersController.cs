using CRUDUsingAdoNet.BusinessLayer;
using CRUDUsingAdoNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUDUsingAdoNet.Controllers
{
    public class TrainersController : Controller
    {
        // GET: Trainers
        public ActionResult Index()
        {
            TrainerBL bl = new TrainerBL();
            List<Trainer> trainers = bl.GetTrainers();


            return View(trainers);
        }

        public ActionResult GetStudentByTrainerId(int? trainerid, string trainername)
        {
            ViewBag.TrainerName = trainername;

            TrainerBL bl = new TrainerBL();
            List<Student> students = bl.GetStudentsByTrainerId(trainerid ?? 0);

            return View(students);
        }

        [HttpGet]
        public ActionResult Details(int? trainerid)
        {
            TrainerBL bl = new TrainerBL();
            Trainer trainer = bl.GetTrainers().Find(t => t.Id == trainerid);
            return View(trainer);
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Create(Trainer trainer)
        {
            TrainerBL bl = new TrainerBL();
            if (bl.create(trainer))
            {
                return RedirectToAction("Index");
            }
            return View();

        }

        [HttpGet]
        public ActionResult Edit(int? trainerId)
        {

            TrainerBL bl = new TrainerBL();
            Trainer trainer = bl.GetTrainers().Find(t => t.Id == trainerId);


            return View(trainer);

        }
        [HttpPost]
        //public ActionResult Edit([Bind(Exclude = "Salary")]Trainer trainer)

        public ActionResult Edit()
        {
            Trainer trainer = new Trainer();
            UpdateModel<Trainer>(trainer);

            TrainerBL bl = new TrainerBL();
            if (bl.Update(trainer))
            {
                return RedirectToAction("Index");
            }
            return View();

        }


        [HttpGet]
        public ActionResult Delete(int? trainerId)
        {

            TrainerBL bl = new TrainerBL();
            Trainer trainer = bl.GetTrainers().Find(t => t.Id == trainerId);

            // bl.Delete(trainerId ?? 0);

            return View(trainer);

        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeletePost(int? trainerId)
        {

            TrainerBL bl = new TrainerBL();
            if (bl.Delete(trainerId ?? 0))
            {
                return RedirectToAction("Index");
            }

            Trainer trainer = bl.GetTrainers().Find(t => t.Id == trainerId);

            return View("Delete",trainer);
        }
    }

}

