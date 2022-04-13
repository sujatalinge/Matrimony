using CRUDUsingAdoNet.DataLayer;
using CRUDUsingAdoNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDUsingAdoNet.BusinessLayer
{
    public class TrainerBL
    {
        TrainerDB _db;
        public TrainerBL()
        {
            _db = new TrainerDB();
        }
        public List<Trainer> GetTrainers()
        {
            return _db.GetTraianers();
        }
        public List<Student> GetStudentsByTrainerId(int trainerid)
        {
            return _db.GetStudentsByTrainerId(trainerid);
        }

        public bool create(Trainer trainer)
        {
            return _db.create(trainer);
        }

        public bool Update(Trainer trainer)
        {
            return _db.Update(trainer);
        }

        public bool Delete(int trainerId)
        {
         return  _db.Delete(trainerId);
        }
    }
}
