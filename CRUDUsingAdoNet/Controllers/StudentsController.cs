using CRUDUsingAdoNet.BusinessLayer;
using CRUDUsingAdoNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUDUsingAdoNet.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details(int? rollNumber)
        {
            StudentBL bl = new StudentBL();
            Student student=bl.GetStudentDetailsByRollNumber(rollNumber ?? 0);


            return View(student);
        }
    }
}