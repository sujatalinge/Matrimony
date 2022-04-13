using CRUDUsingAdoNet.DataLayer;
using CRUDUsingAdoNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDUsingAdoNet.BusinessLayer
{
    public class StudentBL
    {
        StudentDB _db;
        public StudentBL()
        {
            _db = new StudentDB();
        }
        public Student GetStudentDetailsByRollNumber(int rollNumber)
        {
            return _db.GetStudentDetailsByRollNumber(rollNumber);
        }
    }
}